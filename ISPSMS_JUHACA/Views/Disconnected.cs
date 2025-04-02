using Infastructure.Data.Repositories.IRepositories;
using MaterialSkin;
using MaterialSkin.Controls;

using ISPSMS_JUHACA.MainPages;
using Domain.Models;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Presenter;
using Krypton.Toolkit;
using Microsoft.VisualBasic;
using ISPSMS_JUHACA.MainPages.SubPages;
using System.Drawing.Drawing2D;


namespace ISPSMS_JUHACA.Views
{
    public partial class Disconnected : KryptonForm, IDisconnected
    {
        public readonly IUnitOfWork dbContext;
        private System.Windows.Forms.BindingSource bindingSource;

        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        internal Disconnected disconnected;
        private DisconnectedPresenter presenter;
        private SubscriberPage subs;
        private string _currentUsername;
        private string _currentUserRole;

        public ConnectedSubscribers SelectedSubscriber { get; internal set; }

        public Disconnected(IUnitOfWork dbContext, SubscriberPage subs)
        {

            InitializeComponent();
            this.subs = subs;
            _currentUsername = subs._currentUsername;
            _currentUserRole = subs._currentUserRole;

            try
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                this.dbContext = dbContext;
                bindingSource = new System.Windows.Forms.BindingSource();

                presenter = new DisconnectedPresenter(dbContext, this);
                this.Shown += Disconnected_Shown;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Disconnected_Shown(object? sender, EventArgs e)
        {
            presenter.LoadDisconnectedSubscribers();
        }

        private void LogActivity(string activityDescription)
        {
            var activity = new Activity
            {
                AccountName = _currentUsername,
                AccountRole = _currentUserRole,
                ActivitiesDone = activityDescription,
                ActivitiesDateTime = DateTime.Now
            };

            dbContext.activityRepository.Update(activity); // Use Add instead of Update for new records
            dbContext.Save();
        }

        public void SetDisconnectedSubscribers(IEnumerable<DisconnectedSubscribers> subscribers)
        {
            DisconnectedGridView1.DataSource = null;
            DisconnectedGridView1.DataSource = subscribers.ToList(); // Convert to List for binding
        }

        private void DisconnectedGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedSubscriber = (DisconnectedSubscribers)DisconnectedGridView1.Rows[e.RowIndex].DataBoundItem;

                // Handle the "Reconnect" button click
                if (DisconnectedGridView1.Columns[e.ColumnIndex].Name == "reconnectButton")
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to reconnect {selectedSubscriber.Disconn_Name}?",
                                                          "Confirm Reconnection",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            var subscriberToReconnect = dbContext.disconnectedSubscriberRepository
                                                                  .Get(s => s.subs_id == selectedSubscriber.subs_id, tracked: true);

                            if (subscriberToReconnect == null)
                            {
                                MessageBox.Show("Subscriber not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            var dueDate = DateTime.Now.AddMonths(1);
                            var formattedDueDate = GetOrdinal(dueDate.Day);

                            var connectedSubscriber = new ConnectedSubscribers
                            {
                                Conn_Name = subscriberToReconnect.Disconn_Name,
                                ContactNumber = subscriberToReconnect.ContactNumber,
                                Address = subscriberToReconnect.Address,
                                Plan = subscriberToReconnect.Plan,
                                Status = "Active",
                                Duedate = formattedDueDate,
                                CurrentDuedate = DateTime.Now.AddMonths(1),
                                InstallationDate = DateTime.Now,
                                MonthlyCharge = subscriberToReconnect.MonthlyCharge,
                                Balance = subscriberToReconnect.Balance,
                                Charge = subscriberToReconnect.Charge
                            };


                            var mainForm = new MainForm(dbContext);
                            var billingPage = new BillingPage(dbContext, mainForm);
                            var billingCheckout = new BillingCheckout(dbContext, connectedSubscriber, billingPage, mainForm);

                            var res = billingCheckout.ShowDialog();

                            if (res == DialogResult.OK)
                            {
                                dbContext.connectedSubscriberRepository.Add(connectedSubscriber);
                                dbContext.disconnectedSubscriberRepository.Remove(subscriberToReconnect);
                                dbContext.Save(); // Save only after confirmation

                                MessageBox.Show($"{connectedSubscriber.Conn_Name} has been successfully reconnected!",
                                                "Reconnection Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Update UI
                                bindingSource.Remove(selectedSubscriber);
                                presenter.LoadDisconnectedSubscribers();
                                subs.getSubscribers();
                            }
                            else
                            {
                                MessageBox.Show("Reconnection was not completed. Please confirm the billing process.",
                                                "Reconnection Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error while reconnecting: {ex.InnerException?.Message ?? ex.Message}",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (DisconnectedGridView1.Columns[e.ColumnIndex].Name == "deleteButton")
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedSubscriber.Disconn_Name}?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            var subscriberToDelete = dbContext.disconnectedSubscriberRepository
                                                              .Get(s => s.subs_id == selectedSubscriber.subs_id, tracked: true);

                            if (subscriberToDelete == null)
                            {
                                MessageBox.Show("Subscriber not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Remove the subscriber from the database
                            dbContext.disconnectedSubscriberRepository.Remove(subscriberToDelete);
                            dbContext.Save();

                            LogActivity($"Deleted subscriber: {selectedSubscriber.Disconn_Name}");

                            // Update UI
                            bindingSource.Remove(selectedSubscriber);
                            presenter.LoadDisconnectedSubscribers();

                            MessageBox.Show("Subscriber successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error while deleting: {ex.InnerException?.Message ?? ex.Message}",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        public string GetOrdinal(int day)
        {
            if (day % 10 == 1 && day != 11)
                return day + "st";
            if (day % 10 == 2 && day != 12)
                return day + "nd";
            if (day % 10 == 3 && day != 13)
                return day + "rd";
            return day + "th";
        }


        private void DisconnectedGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DisconnectedGridView1.Columns["reconnectButton"].Index ||
                    e.ColumnIndex == DisconnectedGridView1.Columns["deleteButton"].Index)
                {
                    e.Handled = true;

                    Color bgColor = Color.FromArgb(255, 255, 252);
                    using (SolidBrush brush = new SolidBrush(bgColor))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    Image image = null;
                    if (e.ColumnIndex == DisconnectedGridView1.Columns["reconnectButton"].Index)
                    {
                        image = Image.FromFile(@"D:\ISPSMS_FINAL\Icons\reconnect.png");
                    }
                    else if (e.ColumnIndex == DisconnectedGridView1.Columns["deleteButton"].Index)
                    {
                        image = Image.FromFile(@"D:\ISPSMS_FINAL\Icons\minus-circle.png");
                    }

                    if (image != null)
                    {
                        var imageSize = new Size(25, 25);
                        var x = e.CellBounds.Left + (e.CellBounds.Width - imageSize.Width) / 2;
                        var y = e.CellBounds.Top + (e.CellBounds.Height - imageSize.Height) / 2;
                        e.Graphics.DrawImage(image, new Rectangle(new Point(x, y), imageSize));
                    }
                }
            }
            ApplyStatusStyle(e, "Status");
        }

        private void ApplyStatusStyle(DataGridViewCellPaintingEventArgs e, string columnName)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (DisconnectedGridView1.Columns[e.ColumnIndex].DataPropertyName != columnName)
                return;

            string status = e.FormattedValue?.ToString()?.Trim();
            if (string.IsNullOrEmpty(status))
                return;

            DisconnectedGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Color backColor = Color.FromArgb(217, 217, 217); ;
            Color textColor = Color.Gray;
            Color borderColor = Color.Gray; ;

            e.Handled = true;
            using (SolidBrush cellBgBrush = new SolidBrush(Color.FromArgb(255, 255, 252)))
            {
                e.Graphics.FillRectangle(cellBgBrush, e.CellBounds);
            }
            e.PaintBackground(e.CellBounds, true);

            using (SolidBrush brush = new SolidBrush(backColor))
            using (Pen borderPen = new Pen(borderColor, 1)) 
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                SizeF textSize = e.Graphics.MeasureString(status, e.CellStyle.Font);
                int paddingX = 15;
                int paddingY = 5;
                int badgeWidth = (int)textSize.Width + paddingX * 2;
                int badgeHeight = (int)textSize.Height + paddingY;

                int badgeX = e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2;
                int badgeY = e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2;
                Rectangle rect = new Rectangle(badgeX, badgeY, badgeWidth, badgeHeight);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath path = GetRoundedRectanglePath(rect, badgeHeight / 1);

                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(borderPen, path);
                e.Graphics.DrawString(status, e.CellStyle.Font, textBrush, rect, sf);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(bounds.Right - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(bounds.Right - cornerRadius, bounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}