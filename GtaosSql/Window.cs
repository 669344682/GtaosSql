using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
//using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Diagnostics.Eventing.Reader;
using System;
using System.Reflection;

namespace GtaosSql
{
    public partial class Window : Form
    {
        private Dictionary<string, Dictionary<string, string>> mysqlConnectionsDict = new();
        public Window()
        {
            InitializeComponent();
            //Dictionary:
        }



        public void AddNotification(string text)
        {
            richTextBox_output.Text = text + "\n" + richTextBox_output.Text;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm addNew = new(); // Instantiate a addNew object.
            addNew.Show(); // Show addNew and
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Quit
        }

        public void AddNewConnection(string name, string server, string port, string user, string password)
        {
            //richTextBox_output.Text = "正在添加服务器...\n"+ richTextBox_output.Text;
            if (name.Length > 0 & server.Length > 0 & port.Length > 0 & user.Length > 0)
            {
                if (!mysqlConnectionsDict.ContainsKey(name))
                {
                    //字典中不包含重名
                    mysqlConnectionsDict[name] = new Dictionary<string, string>
                    {
                        ["connectionString"] = $"server={server};user id={user};password={password};",
                        ["server"] = server,
                        ["port"] = port,
                        ["user"] = user,
                        ["password"] = password
                    };

                    TreeView treeView = treeView1;  // 创建一个 TreeView 控件实例
                    TreeNode rootNode = new(name); // 创建根节点
                    var nodeIndex = treeView.Nodes.Add(rootNode);   // 添加根节点到 TreeView 控件
                    TreeNode addedNode = treeView.Nodes[nodeIndex]; // 获取根节点
                    addedNode.Tag = "server";   // 给已添加的节点设置 Tag 属性

                    AddNotification("添加Mysql连接成功");
                }
                else
                {
                    AddNotification("存在一个相同名称的Mysql连接，请换其他名称重新尝试");
                }

            }
            else
            {
                AddNotification("信息不完整，请重新添加");
            }
        }

        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNotification("该软件是由GTAOS.COM开发的开源软件，可以访问GTAOS.COM联系我们");
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Tag.ToString() == "server")
            {
                if (mysqlConnectionsDict.ContainsKey(selectedNode.Text))
                {
                    try
                    {
                        //打开数据库
                        var mysqlConnections = new MySqlConnection(mysqlConnectionsDict[selectedNode.Text]["connectionString"]);
                        mysqlConnections.Open();

                        //读取数据库表格
                        string query = "SHOW DATABASES";
                        MySqlCommand command = new(query, mysqlConnections);

                        MySqlDataReader reader = command.ExecuteReader();

                        e.Node.Nodes.Clear();//清除所有子集

                        while (reader.Read())
                        {
                            //e.Node.Nodes.Add(reader.GetString(0));
                            TreeNode childNode = new(reader.GetString(0)); // 添加根节点到 TreeView 控件
                            int nodeIndex = selectedNode.Nodes.Add(childNode);// 获取根节点
                            TreeNode addedNode = selectedNode.Nodes[nodeIndex]; // 给已添加的节点设置 Tag 属性
                            addedNode.Tag = "database"; // 给已添加的节点设置 Tag 属性

                        }
                        AddNotification("Mysql连接成功!");

                        mysqlConnections.Close();
                    }
                    catch (Exception ex)
                    {
                        AddNotification("数据库连接失败，具体信息：" + ex);
                    }

                    return;
                }
            }
            else if (selectedNode.Tag.ToString() == "database")
            {
                try
                {
                    //打开数据库
                    var mysqlConnections = new MySqlConnection(mysqlConnectionsDict[selectedNode.Parent.Text]["connectionString"] + "database=" + selectedNode.Text + ";");
                    mysqlConnections.Open();

                    //读取数据库表格
                    string query = "SHOW TABLES";

                    MySqlCommand command = new(query, mysqlConnections);

                    MySqlDataReader reader = command.ExecuteReader();

                    e.Node.Nodes.Clear();//清除所有子集

                    while (reader.Read())
                    {
                        //e.Node.Nodes.Add(reader.GetString(0));
                        TreeNode grandChildNode = new(reader.GetString(0)); // 添加根节点到 TreeView 控件
                        int nodeIndex = selectedNode.Nodes.Add(grandChildNode);// 获取根节点
                        TreeNode addedNode = selectedNode.Nodes[nodeIndex]; // 给已添加的节点设置 Tag 属性
                        addedNode.Tag = "table"; // 给已添加的节点设置 Tag 属性

                    }
                    AddNotification("数据库连接成功!");
                    mysqlConnections.Close();
                }
                catch (Exception ex)
                {
                    AddNotification("数据库连接失败，具体信息：" + ex);
                }
                return;
            }
            else if (selectedNode.Tag.ToString() == "table")
            {
                try
                {
                    //打开数据库
                    var mysqlConnections = new MySqlConnection(mysqlConnectionsDict[selectedNode.Parent.Parent.Text]["connectionString"] + "database=" + selectedNode.Parent.Text + ";");
                    mysqlConnections.Open();

                    //读取数据库表格
                    string query = $"SELECT * FROM {selectedNode.Text}";
                    MySqlCommand command = new(query, mysqlConnections);
                    MySqlDataAdapter adapter = new(command);
                    DataTable dataTable = new();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    AddNotification($"查询{selectedNode.Text}成功!");
                    mysqlConnections.Close();
                }
                catch (Exception ex)
                {
                    AddNotification("数据库连接失败，具体信息：" + ex);
                }
                return;
            }
        }
    }
}