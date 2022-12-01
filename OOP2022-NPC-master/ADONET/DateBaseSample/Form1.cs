﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBaseSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void 社員BindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.社員BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202211DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            

        }

        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202211DataSet.社員' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.社員TableAdapter.Fill(this.infosys202211DataSet.社員);
        }

        private void btSave_Click(object sender, EventArgs e) {
            this.Validate();
            this.社員BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202211DataSet);

            //this.社員TableAdapter.Update(this.infosys202211DataSet.社員);
        }

        private void btExecute_Click(object sender, EventArgs e) {
            this.社員TableAdapter.FillBySalary(this.infosys202211DataSet.社員,int.Parse(tbValue.Text));
        }
    }
}
