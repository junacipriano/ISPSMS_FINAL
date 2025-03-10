using Infastructure.Data.Repositories.IRepositories;
using MaterialSkin;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class Transaction : Form
    {
        public readonly IUnitOfWork dbContext;
        public Transaction(IUnitOfWork dbContext, MainForm mainform)
        {
            InitializeComponent();
            this.dbContext = dbContext;

        }

    }
}
