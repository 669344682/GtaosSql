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

        private void �½�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm addNew = new(); // Instantiate a addNew object.
            addNew.Show(); // Show addNew and
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Quit
        }

        public void AddNewConnection(string name, string server, string port, string user, string password)
        {
            //richTextBox_output.Text = "������ӷ�����...\n"+ richTextBox_output.Text;
            if (name.Length > 0 & server.Length > 0 & port.Length > 0 & user.Length > 0)
            {
                if (!mysqlConnectionsDict.ContainsKey(name))
                {
                    //�ֵ��в���������
                    mysqlConnectionsDict[name] = new Dictionary<string, string>
                    {
                        ["connectionString"] = $"server={server};user id={user};password={password};",
                        ["server"] = server,
                        ["port"] = port,
                        ["user"] = user,
                        ["password"] = password
                    };

                    TreeView treeView = treeView1;  // ����һ�� TreeView �ؼ�ʵ��
                    TreeNode rootNode = new(name); // �������ڵ�
                    var nodeIndex = treeView.Nodes.Add(rootNode);   // ��Ӹ��ڵ㵽 TreeView �ؼ�
                    TreeNode addedNode = treeView.Nodes[nodeIndex]; // ��ȡ���ڵ�
                    addedNode.Tag = "server";   // ������ӵĽڵ����� Tag ����

                    AddNotification("���Mysql���ӳɹ�");
                }
                else
                {
                    AddNotification("����һ����ͬ���Ƶ�Mysql���ӣ��뻻�����������³���");
                }

            }
            else
            {
                AddNotification("��Ϣ�����������������");
            }
        }

        private void ˵��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNotification("���������GTAOS.COM�����Ŀ�Դ��������Է���GTAOS.COM��ϵ����");
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
                        //�����ݿ�
                        var mysqlConnections = new MySqlConnection(mysqlConnectionsDict[selectedNode.Text]["connectionString"]);
                        mysqlConnections.Open();

                        //��ȡ���ݿ���
                        string query = "SHOW DATABASES";
                        MySqlCommand command = new(query, mysqlConnections);

                        MySqlDataReader reader = command.ExecuteReader();

                        e.Node.Nodes.Clear();//��������Ӽ�

                        while (reader.Read())
                        {
                            //e.Node.Nodes.Add(reader.GetString(0));
                            TreeNode childNode = new(reader.GetString(0)); // ��Ӹ��ڵ㵽 TreeView �ؼ�
                            int nodeIndex = selectedNode.Nodes.Add(childNode);// ��ȡ���ڵ�
                            TreeNode addedNode = selectedNode.Nodes[nodeIndex]; // ������ӵĽڵ����� Tag ����
                            addedNode.Tag = "database"; // ������ӵĽڵ����� Tag ����

                        }
                        AddNotification("Mysql���ӳɹ�!");

                        mysqlConnections.Close();
                    }
                    catch (Exception ex)
                    {
                        AddNotification("���ݿ�����ʧ�ܣ�������Ϣ��" + ex);
                    }

                    return;
                }
            }
            else if (selectedNode.Tag.ToString() == "database")
            {
                try
                {
                    //�����ݿ�
                    var mysqlConnections = new MySqlConnection(mysqlConnectionsDict[selectedNode.Parent.Text]["connectionString"] + "database=" + selectedNode.Text + ";");
                    mysqlConnections.Open();

                    //��ȡ���ݿ���
                    string query = "SHOW TABLES";

                    MySqlCommand command = new(query, mysqlConnections);

                    MySqlDataReader reader = command.ExecuteReader();

                    e.Node.Nodes.Clear();//��������Ӽ�

                    while (reader.Read())
                    {
                        //e.Node.Nodes.Add(reader.GetString(0));
                        TreeNode grandChildNode = new(reader.GetString(0)); // ��Ӹ��ڵ㵽 TreeView �ؼ�
                        int nodeIndex = selectedNode.Nodes.Add(grandChildNode);// ��ȡ���ڵ�
                        TreeNode addedNode = selectedNode.Nodes[nodeIndex]; // ������ӵĽڵ����� Tag ����
                        addedNode.Tag = "table"; // ������ӵĽڵ����� Tag ����

                    }
                    AddNotification("���ݿ����ӳɹ�!");
                    mysqlConnections.Close();
                }
                catch (Exception ex)
                {
                    AddNotification("���ݿ�����ʧ�ܣ�������Ϣ��" + ex);
                }
                return;
            }
            else if (selectedNode.Tag.ToString() == "table")
            {
                try
                {
                    //�����ݿ�
                    var mysqlConnections = new MySqlConnection(mysqlConnectionsDict[selectedNode.Parent.Parent.Text]["connectionString"] + "database=" + selectedNode.Parent.Text + ";");
                    mysqlConnections.Open();

                    //��ȡ���ݿ���
                    string query = $"SELECT * FROM {selectedNode.Text}";
                    MySqlCommand command = new(query, mysqlConnections);
                    MySqlDataAdapter adapter = new(command);
                    DataTable dataTable = new();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    AddNotification($"��ѯ{selectedNode.Text}�ɹ�!");
                    mysqlConnections.Close();
                }
                catch (Exception ex)
                {
                    AddNotification("���ݿ�����ʧ�ܣ�������Ϣ��" + ex);
                }
                return;
            }
        }
    }
}