namespace Golikov_WinFormHospital
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.DoctorsTabPage = new System.Windows.Forms.TabPage();
            this.DoctorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DoctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.PatientsTabPage = new System.Windows.Forms.TabPage();
            this.PatientsDataGridView = new System.Windows.Forms.DataGridView();
            this.DoctorVisitsTabPage = new System.Windows.Forms.TabPage();
            this.DoctorVisitsDataGridView = new System.Windows.Forms.DataGridView();
            this.MainTabControl.SuspendLayout();
            this.DoctorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.DoctorsBindingNavigator)).BeginInit();
            this.DoctorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.DoctorsDataGridView)).BeginInit();
            this.PatientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.PatientsDataGridView)).BeginInit();
            this.DoctorVisitsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.DoctorVisitsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.DoctorsTabPage);
            this.MainTabControl.Controls.Add(this.PatientsTabPage);
            this.MainTabControl.Controls.Add(this.DoctorVisitsTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(800, 450);
            this.MainTabControl.TabIndex = 0;
            // 
            // DoctorsTabPage
            // 
            this.DoctorsTabPage.Controls.Add(this.DoctorsBindingNavigator);
            this.DoctorsTabPage.Controls.Add(this.DoctorsDataGridView);
            this.DoctorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DoctorsTabPage.Name = "DoctorsTabPage";
            this.DoctorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DoctorsTabPage.Size = new System.Drawing.Size(792, 424);
            this.DoctorsTabPage.TabIndex = 0;
            this.DoctorsTabPage.Text = "Врачи";
            this.DoctorsTabPage.UseVisualStyleBackColor = true;
            // 
            // DoctorsBindingNavigator
            // 
            this.DoctorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.DoctorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.DoctorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.DoctorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.toolStripButton1});
            this.DoctorsBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.DoctorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.DoctorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.DoctorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.DoctorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.DoctorsBindingNavigator.Name = "DoctorsBindingNavigator";
            this.DoctorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.DoctorsBindingNavigator.Size = new System.Drawing.Size(786, 25);
            this.DoctorsBindingNavigator.TabIndex = 1;
            this.DoctorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // DoctorsDataGridView
            // 
            this.DoctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DoctorsDataGridView.Location = new System.Drawing.Point(3, 31);
            this.DoctorsDataGridView.Name = "DoctorsDataGridView";
            this.DoctorsDataGridView.Size = new System.Drawing.Size(786, 390);
            this.DoctorsDataGridView.TabIndex = 0;
            // 
            // PatientsTabPage
            // 
            this.PatientsTabPage.Controls.Add(this.PatientsDataGridView);
            this.PatientsTabPage.Location = new System.Drawing.Point(4, 22);
            this.PatientsTabPage.Name = "PatientsTabPage";
            this.PatientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PatientsTabPage.Size = new System.Drawing.Size(792, 424);
            this.PatientsTabPage.TabIndex = 1;
            this.PatientsTabPage.Text = "Пациенты";
            this.PatientsTabPage.UseVisualStyleBackColor = true;
            // 
            // PatientsDataGridView
            // 
            this.PatientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.PatientsDataGridView.Name = "PatientsDataGridView";
            this.PatientsDataGridView.Size = new System.Drawing.Size(786, 418);
            this.PatientsDataGridView.TabIndex = 0;
            // 
            // DoctorVisitsTabPage
            // 
            this.DoctorVisitsTabPage.Controls.Add(this.DoctorVisitsDataGridView);
            this.DoctorVisitsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DoctorVisitsTabPage.Name = "DoctorVisitsTabPage";
            this.DoctorVisitsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DoctorVisitsTabPage.Size = new System.Drawing.Size(792, 424);
            this.DoctorVisitsTabPage.TabIndex = 2;
            this.DoctorVisitsTabPage.Text = "Приёмы";
            this.DoctorVisitsTabPage.UseVisualStyleBackColor = true;
            // 
            // DoctorVisitsDataGridView
            // 
            this.DoctorVisitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorVisitsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorVisitsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DoctorVisitsDataGridView.Name = "DoctorVisitsDataGridView";
            this.DoctorVisitsDataGridView.Size = new System.Drawing.Size(786, 418);
            this.DoctorVisitsDataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabControl);
            this.Name = "Form1";
            this.Text = "Hospital";
            this.MainTabControl.ResumeLayout(false);
            this.DoctorsTabPage.ResumeLayout(false);
            this.DoctorsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.DoctorsBindingNavigator)).EndInit();
            this.DoctorsBindingNavigator.ResumeLayout(false);
            this.DoctorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.DoctorsDataGridView)).EndInit();
            this.PatientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.PatientsDataGridView)).EndInit();
            this.DoctorVisitsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.DoctorVisitsDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.BindingNavigator DoctorsBindingNavigator;

        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;

        private System.Windows.Forms.DataGridView DoctorVisitsDataGridView;

        private System.Windows.Forms.TabPage DoctorVisitsTabPage;
        private System.Windows.Forms.TabControl MainTabControl;

        private System.Windows.Forms.DataGridView PatientsDataGridView;

        private System.Windows.Forms.TabPage PatientsTabPage;

        private System.Windows.Forms.DataGridView DoctorsDataGridView;

        private System.Windows.Forms.TabPage DoctorsTabPage;

        #endregion
    }
}