using Microsoft.EntityFrameworkCore.Diagnostics;
using SMS.App.Views.IViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.App
{
    public partial class ProgramView : Form, IProgramView
    {
        public ProgramView()
        {
            InitializeComponent();

            dataGridViewProgramList.CellClick += (s, e) =>
            {
                GetInfoEvent?.Invoke(this, e);
            };
        }

        public event EventHandler CreateEvent;

        public event EventHandler ReadEvent;

        public event EventHandler UpdateEvent;

        public event EventHandler DeleteEvent;

        public event EventHandler GetInfoEvent;

        public int ProgramId { get => string.IsNullOrEmpty(textBoxID.Text) ? 0 : Convert.ToInt16(textBoxID.Text); set => textBoxID.Text = value.ToString(); }
        public string ProgramName { get => textBoxProgramName.Text.Trim(); set => textBoxProgramName.Text = value; }
        public string Description { get => textBoxDescription.Text.Trim(); set => textBoxDescription.Text = value; }
        public string SearchValue { get => textBoxSearch.Text.Trim(); }

        public void GetProgramList(BindingSource bindingSource)
        {
            dataGridViewProgramList.DataSource = bindingSource;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateEvent?.Invoke(this, EventArgs.Empty);
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            ReadEvent?.Invoke(this, EventArgs.Empty);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateEvent?.Invoke(this, EventArgs.Empty);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteEvent?.Invoke(this, EventArgs.Empty);
        }

        public void SetMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void ProgramView_Load(object sender, EventArgs e)
        {

        }
    }
}
