
namespace LootSystemCreater
{
    partial class MainMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tablesB = new System.Windows.Forms.ToolStripButton();
            this.groupsB = new System.Windows.Forms.ToolStripButton();
            this.itemsB = new System.Windows.Forms.ToolStripButton();
            this.importB = new System.Windows.Forms.ToolStripButton();
            this.exportB = new System.Windows.Forms.ToolStripButton();
            this.itemsP = new System.Windows.Forms.Panel();
            this.itemErrorL = new System.Windows.Forms.Label();
            this.saveItemsB = new System.Windows.Forms.Button();
            this.varTypesCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.varNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addVarB = new System.Windows.Forms.Button();
            this.addItemTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemB = new System.Windows.Forms.Button();
            this.itemTable = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsP = new System.Windows.Forms.Panel();
            this.groupErrorL = new System.Windows.Forms.Label();
            this.addItemToGroupB = new System.Windows.Forms.Button();
            this.rmItemFromGroup = new System.Windows.Forms.Button();
            this.saveAllGroupsB = new System.Windows.Forms.Button();
            this.groupsItemTabel = new System.Windows.Forms.DataGridView();
            this.addGroupTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addGroupB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupsCB = new System.Windows.Forms.ComboBox();
            this.groupsTabel = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.itemsP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).BeginInit();
            this.groupsP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsItemTabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsTabel)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesB,
            this.groupsB,
            this.itemsB,
            this.importB,
            this.exportB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(968, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tablesB
            // 
            this.tablesB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tablesB.Image = ((System.Drawing.Image)(resources.GetObject("tablesB.Image")));
            this.tablesB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tablesB.Name = "tablesB";
            this.tablesB.Size = new System.Drawing.Size(43, 22);
            this.tablesB.Text = "Tables";
            // 
            // groupsB
            // 
            this.groupsB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.groupsB.Image = ((System.Drawing.Image)(resources.GetObject("groupsB.Image")));
            this.groupsB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupsB.Name = "groupsB";
            this.groupsB.Size = new System.Drawing.Size(49, 22);
            this.groupsB.Text = "Groups";
            this.groupsB.Click += new System.EventHandler(this.groupsB_Click);
            // 
            // itemsB
            // 
            this.itemsB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.itemsB.Image = ((System.Drawing.Image)(resources.GetObject("itemsB.Image")));
            this.itemsB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemsB.Name = "itemsB";
            this.itemsB.Size = new System.Drawing.Size(40, 22);
            this.itemsB.Text = "Items";
            this.itemsB.Click += new System.EventHandler(this.itemsB_Click);
            // 
            // importB
            // 
            this.importB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importB.Image = ((System.Drawing.Image)(resources.GetObject("importB.Image")));
            this.importB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importB.Name = "importB";
            this.importB.Size = new System.Drawing.Size(47, 22);
            this.importB.Text = "Import";
            // 
            // exportB
            // 
            this.exportB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportB.Image = ((System.Drawing.Image)(resources.GetObject("exportB.Image")));
            this.exportB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportB.Name = "exportB";
            this.exportB.Size = new System.Drawing.Size(45, 22);
            this.exportB.Text = "Export";
            // 
            // itemsP
            // 
            this.itemsP.Controls.Add(this.itemErrorL);
            this.itemsP.Controls.Add(this.saveItemsB);
            this.itemsP.Controls.Add(this.varTypesCB);
            this.itemsP.Controls.Add(this.label3);
            this.itemsP.Controls.Add(this.varNameTB);
            this.itemsP.Controls.Add(this.label2);
            this.itemsP.Controls.Add(this.addVarB);
            this.itemsP.Controls.Add(this.addItemTB);
            this.itemsP.Controls.Add(this.label1);
            this.itemsP.Controls.Add(this.addItemB);
            this.itemsP.Controls.Add(this.itemTable);
            this.itemsP.Location = new System.Drawing.Point(12, 28);
            this.itemsP.Name = "itemsP";
            this.itemsP.Size = new System.Drawing.Size(379, 197);
            this.itemsP.TabIndex = 1;
            // 
            // itemErrorL
            // 
            this.itemErrorL.AutoSize = true;
            this.itemErrorL.Location = new System.Drawing.Point(4, 70);
            this.itemErrorL.Name = "itemErrorL";
            this.itemErrorL.Size = new System.Drawing.Size(0, 13);
            this.itemErrorL.TabIndex = 11;
            // 
            // saveItemsB
            // 
            this.saveItemsB.Location = new System.Drawing.Point(272, 11);
            this.saveItemsB.Name = "saveItemsB";
            this.saveItemsB.Size = new System.Drawing.Size(104, 23);
            this.saveItemsB.TabIndex = 10;
            this.saveItemsB.Text = "Save Items";
            this.saveItemsB.UseVisualStyleBackColor = true;
            this.saveItemsB.Click += new System.EventHandler(this.saveItemsB_Click);
            // 
            // varTypesCB
            // 
            this.varTypesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.varTypesCB.FormattingEnabled = true;
            this.varTypesCB.Location = new System.Drawing.Point(272, 41);
            this.varTypesCB.Name = "varTypesCB";
            this.varTypesCB.Size = new System.Drawing.Size(104, 21);
            this.varTypesCB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // varNameTB
            // 
            this.varNameTB.Location = new System.Drawing.Point(125, 43);
            this.varNameTB.Name = "varNameTB";
            this.varNameTB.Size = new System.Drawing.Size(100, 20);
            this.varNameTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // addVarB
            // 
            this.addVarB.Location = new System.Drawing.Point(3, 41);
            this.addVarB.Name = "addVarB";
            this.addVarB.Size = new System.Drawing.Size(75, 23);
            this.addVarB.TabIndex = 5;
            this.addVarB.Text = "Add Variable";
            this.addVarB.UseVisualStyleBackColor = true;
            this.addVarB.Click += new System.EventHandler(this.addVarB_Click);
            // 
            // addItemTB
            // 
            this.addItemTB.Location = new System.Drawing.Point(125, 14);
            this.addItemTB.Name = "addItemTB";
            this.addItemTB.Size = new System.Drawing.Size(100, 20);
            this.addItemTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // addItemB
            // 
            this.addItemB.Location = new System.Drawing.Point(3, 12);
            this.addItemB.Name = "addItemB";
            this.addItemB.Size = new System.Drawing.Size(75, 23);
            this.addItemB.TabIndex = 2;
            this.addItemB.Text = "Add Item";
            this.addItemB.UseVisualStyleBackColor = true;
            this.addItemB.Click += new System.EventHandler(this.addItemB_Click);
            // 
            // itemTable
            // 
            this.itemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName});
            this.itemTable.Location = new System.Drawing.Point(3, 89);
            this.itemTable.Name = "itemTable";
            this.itemTable.Size = new System.Drawing.Size(373, 105);
            this.itemTable.TabIndex = 1;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "[string] itemName";
            this.ItemName.Name = "ItemName";
            // 
            // groupsP
            // 
            this.groupsP.Controls.Add(this.groupErrorL);
            this.groupsP.Controls.Add(this.addItemToGroupB);
            this.groupsP.Controls.Add(this.rmItemFromGroup);
            this.groupsP.Controls.Add(this.saveAllGroupsB);
            this.groupsP.Controls.Add(this.groupsItemTabel);
            this.groupsP.Controls.Add(this.addGroupTB);
            this.groupsP.Controls.Add(this.label5);
            this.groupsP.Controls.Add(this.addGroupB);
            this.groupsP.Controls.Add(this.label4);
            this.groupsP.Controls.Add(this.groupsCB);
            this.groupsP.Controls.Add(this.groupsTabel);
            this.groupsP.Location = new System.Drawing.Point(15, 231);
            this.groupsP.Name = "groupsP";
            this.groupsP.Size = new System.Drawing.Size(594, 282);
            this.groupsP.TabIndex = 2;
            // 
            // groupErrorL
            // 
            this.groupErrorL.AutoSize = true;
            this.groupErrorL.Location = new System.Drawing.Point(347, 68);
            this.groupErrorL.Name = "groupErrorL";
            this.groupErrorL.Size = new System.Drawing.Size(0, 13);
            this.groupErrorL.TabIndex = 18;
            // 
            // addItemToGroupB
            // 
            this.addItemToGroupB.Location = new System.Drawing.Point(258, 89);
            this.addItemToGroupB.Name = "addItemToGroupB";
            this.addItemToGroupB.Size = new System.Drawing.Size(75, 23);
            this.addItemToGroupB.TabIndex = 17;
            this.addItemToGroupB.Text = "<- Add";
            this.addItemToGroupB.UseVisualStyleBackColor = true;
            this.addItemToGroupB.Click += new System.EventHandler(this.addItemToGroupB_Click);
            // 
            // rmItemFromGroup
            // 
            this.rmItemFromGroup.Location = new System.Drawing.Point(258, 118);
            this.rmItemFromGroup.Name = "rmItemFromGroup";
            this.rmItemFromGroup.Size = new System.Drawing.Size(75, 23);
            this.rmItemFromGroup.TabIndex = 16;
            this.rmItemFromGroup.Text = "Remove ->";
            this.rmItemFromGroup.UseVisualStyleBackColor = true;
            // 
            // saveAllGroupsB
            // 
            this.saveAllGroupsB.Location = new System.Drawing.Point(258, 33);
            this.saveAllGroupsB.Name = "saveAllGroupsB";
            this.saveAllGroupsB.Size = new System.Drawing.Size(75, 21);
            this.saveAllGroupsB.TabIndex = 15;
            this.saveAllGroupsB.Text = "Save All";
            this.saveAllGroupsB.UseVisualStyleBackColor = true;
            // 
            // groupsItemTabel
            // 
            this.groupsItemTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsItemTabel.Location = new System.Drawing.Point(350, 92);
            this.groupsItemTabel.Name = "groupsItemTabel";
            this.groupsItemTabel.Size = new System.Drawing.Size(240, 150);
            this.groupsItemTabel.TabIndex = 14;
            // 
            // addGroupTB
            // 
            this.addGroupTB.Location = new System.Drawing.Point(124, 33);
            this.addGroupTB.Name = "addGroupTB";
            this.addGroupTB.Size = new System.Drawing.Size(100, 20);
            this.addGroupTB.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // addGroupB
            // 
            this.addGroupB.Location = new System.Drawing.Point(6, 31);
            this.addGroupB.Name = "addGroupB";
            this.addGroupB.Size = new System.Drawing.Size(75, 23);
            this.addGroupB.TabIndex = 3;
            this.addGroupB.Text = "Add Group";
            this.addGroupB.UseVisualStyleBackColor = true;
            this.addGroupB.Click += new System.EventHandler(this.addGroupB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Groups:";
            // 
            // groupsCB
            // 
            this.groupsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsCB.FormattingEnabled = true;
            this.groupsCB.Location = new System.Drawing.Point(53, 65);
            this.groupsCB.Name = "groupsCB";
            this.groupsCB.Size = new System.Drawing.Size(191, 21);
            this.groupsCB.TabIndex = 1;
            // 
            // groupsTabel
            // 
            this.groupsTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsTabel.Location = new System.Drawing.Point(4, 92);
            this.groupsTabel.Name = "groupsTabel";
            this.groupsTabel.Size = new System.Drawing.Size(240, 150);
            this.groupsTabel.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 541);
            this.Controls.Add(this.groupsP);
            this.Controls.Add(this.itemsP);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.itemsP.ResumeLayout(false);
            this.itemsP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).EndInit();
            this.groupsP.ResumeLayout(false);
            this.groupsP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsItemTabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsTabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tablesB;
        private System.Windows.Forms.ToolStripButton groupsB;
        private System.Windows.Forms.ToolStripButton itemsB;
        private System.Windows.Forms.ToolStripButton importB;
        private System.Windows.Forms.Panel itemsP;
        private System.Windows.Forms.DataGridView itemTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addItemB;
        private System.Windows.Forms.TextBox addItemTB;
        private System.Windows.Forms.ComboBox varTypesCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox varNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addVarB;
        private System.Windows.Forms.ToolStripButton exportB;
        private System.Windows.Forms.Button saveItemsB;
        private System.Windows.Forms.Label itemErrorL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.Panel groupsP;
        private System.Windows.Forms.Button addItemToGroupB;
        private System.Windows.Forms.Button rmItemFromGroup;
        private System.Windows.Forms.Button saveAllGroupsB;
        private System.Windows.Forms.DataGridView groupsItemTabel;
        private System.Windows.Forms.TextBox addGroupTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addGroupB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox groupsCB;
        private System.Windows.Forms.DataGridView groupsTabel;
        private System.Windows.Forms.Label groupErrorL;
    }
}

