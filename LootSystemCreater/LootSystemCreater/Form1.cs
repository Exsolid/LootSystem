using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LootSystemCreater.data;

namespace LootSystemCreater
{
    public partial class MainMenu : Form
    {
        private Panel[] panels;
        private MainData mainData;

        public MainMenu()
        {
            InitializeComponent();
            mainData = new MainData();
            panels = new Panel[3];
            panels[2] = itemsP;
            panels[1] = groupsP;
            showPanel(0);
            buildItemPanel();
            buildGroupPanel();
        }

        //General Buttons
        private void itemsB_Click(object sender, EventArgs e)
        {
            showPanel(2);
            buildItemPanel();
        }

        private void groupsB_Click(object sender, EventArgs e)
        {
            showPanel(1);
            buildGroupPanel();
        }

        private void showPanel(int panelID)
        {
            foreach (Panel pan in panels)
            {
                if (pan != null) pan.Visible = false;
            }
            if (panels[panelID] != null) panels[panelID].Visible = true;
        }

        //Group stuff
        private void buildGroupPanel()
        {
            groupErrorL.Text = "";
            groupsItemTabel.AllowUserToAddRows = false;
            groupsTabel.AllowUserToAddRows = false;
            updateGroupTabels();
        }

        private void addGroupB_Click(object sender, EventArgs e)
        {
            groupsTabel.AllowUserToAddRows = true;
            if (!isEmpty(addGroupTB.Text))
            {
                groupsCB.Items.Add(addGroupTB.Text);
                groupsCB.SelectedItem = addGroupTB.Text;
                mainData.Groups.Add(new data.Group(addGroupTB.Text));
            }
            groupsTabel.AllowUserToAddRows = false;
        }
        private void addItemToGroupB_Click(object sender, EventArgs e)
        {
            if(groupsCB.SelectedIndex < 0)
            {
                groupErrorL.Text = "No group created yet!";
                return;
            }
            //Copy row
            for(int rowI = 0; rowI < groupsItemTabel.SelectedRows.Count; rowI++)
            {
                DataGridViewRow row = (DataGridViewRow)groupsItemTabel.SelectedRows[rowI].Clone();
                for(int cellI = 0; cellI < row.Cells.Count; cellI++)
                {
                    row.Cells[cellI].Value = groupsItemTabel.SelectedRows[rowI].Cells[cellI].Value;
                }
                groupsTabel.Rows.Add(row);
            }
            //Remove row
            for (int rowI = 0; rowI < groupsItemTabel.SelectedRows.Count; rowI++)
            {
                groupsItemTabel.Rows.Remove(groupsItemTabel.SelectedRows[rowI]);
            }
        }

        private void updateGroupTabels()
        {
            //Update items
            groupsItemTabel.Rows.Clear();
            groupsItemTabel.Columns.Clear();
            groupsTabel.Rows.Clear();
            groupsTabel.Columns.Clear();
            //Copy all variables to groups
            foreach (DataGridViewColumn col in itemTable.Columns)
            {
                groupsItemTabel.Columns.Add((DataGridViewColumn)col.Clone());
            }

            foreach (DataGridViewColumn col in itemTable.Columns)
            {
                groupsTabel.Columns.Add((DataGridViewColumn)col.Clone());
            }

            //Fill values
            for (int rowI = 0; rowI < itemTable.RowCount; rowI++)
            {
                if (mainData.getItem(rowI).getValueAsString(0) == "")
                {
                    groupErrorL.Text = "The item list incomplete! Did you forget to save?";
                    break;
                }
                groupsItemTabel.Rows.Add((DataGridViewRow)itemTable.Rows[rowI].Clone());
            }

            for (int rowI = 0; rowI < groupsItemTabel.RowCount; rowI++)
            {
                for (int colI = 0; colI < groupsItemTabel.ColumnCount; colI++)
                {
                    groupsItemTabel.Rows[rowI].Cells[colI].Value = mainData.getItem(rowI).getValueAsString(colI);
                }
            }
        }

        //Item stuff
        private void buildItemPanel()
        {
            itemErrorL.Text = "";
            if (varTypesCB.Items.Count == 0)
            {
                varTypesCB.DropDownStyle = ComboBoxStyle.DropDownList;
                varTypesCB.Items.Add("int");
                varTypesCB.Items.Add("string");
                varTypesCB.Items.Add("char");
                varTypesCB.Items.Add("float");
                varTypesCB.Items.Add("double");
                mainData.addItemArg("itemName", "string");
                varTypesCB.SelectedIndex = 0;
                itemTable.AllowUserToAddRows = false;
            }
        }

        private void addItemB_Click(object sender, EventArgs e)
        {
            itemTable.AllowUserToAddRows = true;
            if (!isEmpty(addItemTB.Text))
            {
                try
                {
                    mainData.newItem(addItemTB.Text);
                    DataGridViewRow row = (DataGridViewRow)itemTable.Rows[0].Clone();
                    row.Cells[0].Value = addItemTB.Text;
                    itemTable.Rows.Add(row);
                }catch(Exception ex)
                {
                    itemErrorL.Text = ex.Message;
                }
            }
            else
            {
                itemErrorL.Text = "The item name must not be empty!";
            }
            itemTable.AllowUserToAddRows = false;
        }

        private void addVarB_Click(object sender, EventArgs e)
        {
            if (isVarRegex(varNameTB.Text))
            {
                try
                {
                    mainData.addItemArg(varNameTB.Text, varTypesCB.Text);
                    DataGridViewColumn col = (DataGridViewColumn)itemTable.Columns[0].Clone();
                    col.HeaderText = "["+ varTypesCB.Text+"] "+varNameTB.Text;
                    itemTable.Columns.Add(col);
                }
                catch (Exception ex)
                {
                    itemErrorL.Text = ex.Message;
                }
            }
            else
            {
                if (!isEmpty(varNameTB.Text)) itemErrorL.Text = "The variable name is not C# conform!";
                else itemErrorL.Text = "The variable name must not be empty!";
            }
        }

        private void saveItemsB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < itemTable.RowCount; i++)
            {
                if (!isEmpty(itemTable.Rows[i].Cells[0].Value.ToString()))
                {
                    for(int argI = 0; argI < itemTable.ColumnCount; argI++)
                    {
                        try
                        {
                            switch (getTypeForHeader(itemTable.Columns[argI].HeaderText))
                            {
                                case "int":
                                    mainData.getItem(i).changeValue<int>(getNameForHeader(itemTable.Columns[argI].HeaderText), itemTable.Rows[0].Cells[argI].Value);
                                    break;
                                case "string":
                                    mainData.getItem(i).changeValue<string>(getNameForHeader(itemTable.Columns[argI].HeaderText), itemTable.Rows[0].Cells[argI].Value);
                                    break;
                                case "char":
                                    mainData.getItem(i).changeValue<char>(getNameForHeader(itemTable.Columns[argI].HeaderText), itemTable.Rows[0].Cells[argI].Value);
                                    break;
                                case "float":
                                    mainData.getItem(i).changeValue<float>(getNameForHeader(itemTable.Columns[argI].HeaderText), itemTable.Rows[0].Cells[argI].Value);
                                    break;
                                case "double":
                                    mainData.getItem(i).changeValue<double>(getNameForHeader(itemTable.Columns[argI].HeaderText), itemTable.Rows[0].Cells[argI].Value);
                                    break;
                            }
                        }catch(Exception ex)
                        {
                            itemErrorL.Text = "The value [" + itemTable.Rows[0].Cells[argI].Value + "] does not match the type [" + getTypeForHeader(itemTable.Columns[argI].HeaderText) + "]! See column: " + getNameForHeader(itemTable.Columns[argI].HeaderText);
                        }
                    }
                }
            }
        }

        //Misc
        private bool isEmpty(string st)
        {
            char[] cs = st.ToCharArray();
            foreach(char c in cs)
            {
                if (!c.Equals(" ")) return false;
            }
            return true;
        }

        private bool isVarRegex(string st)
        {
            if (!isEmpty(st))
            {
                if (Regex.IsMatch(st, "^[a-zA-Z][a-zA-Z_$0-9]*$")) return true;
            }
            return false;
        }

        private string getTypeForHeader(string st)
        {
            char[] cs = st.ToCharArray();
            string type = "";
            bool reading = false;
            foreach (char c in cs)
            {
                if (c.Equals('[')) reading = true;
                else if (c.Equals(']')) return type;
                else if (reading) type += c;
            }
            return null;
        }

        private string getNameForHeader(string st)
        {
            char[] cs = st.ToCharArray();
            string name = "";
            bool reading = false;
            foreach (char c in cs)
            {
                if (c.Equals(' ')) reading = true;
                else if (reading) name += c;
            }
            return name;
        }
    }
}
