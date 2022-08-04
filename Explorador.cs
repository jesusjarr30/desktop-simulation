using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

using Microsoft.VisualBasic.Devices;

namespace Escritorio
{
    public partial class Explorador : Form

    {
  
        private string filePath = "C:\\Users\\chuyi\\OneDrive\\Documentos";
        private bool isFile = false;
        private string currentlyselectedItemName="";
        private string correccion = "";
        private string seleccion = "";
        private string nombre = "";
        private bool V_copiar = false;
        private bool V_mover = false;
        
        public Explorador()
        {
            InitializeComponent();
        }

        private void Explorador_Load(object sender, EventArgs e)
        {
            filePathtextBox.Text = filePath;
            loadFilesAndDirectories();
            
        }
        private void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {

                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlyselectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    lbName.Text = fileDetails.Name;
                    lbType.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);

                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);

                }
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();
                    listView1.Items.Clear();
                    string fileExtension = "";
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 2);
                                break;
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 0);
                                break;
                            case ".PNG":
                            case ".JPNG":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".XLSX":
                                listView1.Items.Add(files[i].Name, 1);
                                break;
                            case ".TXT":
                                listView1.Items.Add(files[i].Name, 5);
                                break;

                            default:
                                listView1.Items.Add(files[i].Name, 6);
                                break;

                        }     
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 4);
                    }
                }
                else
                {
                    lbName.Text = this.currentlyselectedItemName;
                }
            }
            catch (Exception e)
            {

            }
        }


        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlyselectedItemName = e.Item.Text;
            correccion = filePath + "\\" + currentlyselectedItemName;

            FileAttributes fileAttr = File.GetAttributes(filePath + "\\" + currentlyselectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathtextBox.Text = filePath + "\\" + currentlyselectedItemName;
            }
            else
            {
                isFile = true;
            }

        }
        
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            filePath = filePathtextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }
        public void loadButonAction()
        {
            filePath = filePathtextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            goBack();
            loadButonAction();
        }
        public void removeBackSlash()
        {
            string path = filePathtextBox.Text;
            if (path.LastIndexOf("\\") == path.Length - 1)
            {
                filePathtextBox.Text = path.Substring(0, path.Length - 1);
            }
        }
        public void goBack()
        {
            try
            {
                removeBackSlash();
                string Path = filePathtextBox.Text;
                Path = Path.Substring(0, Path.LastIndexOf("\\"));
                this.isFile = false;
                filePathtextBox.Text = Path;
                removeBackSlash();

            }
            catch(Exception e)
            {

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccion = correccion;
            nombre = currentlyselectedItemName;
            V_copiar = true;
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (V_copiar)
            {
                try
                {
                    //MessageBox.Show("1:" + seleccion + "  2:  " + correcion);
                    File.Copy(seleccion, $"{correccion}\\{nombre}");
                    V_copiar = false;
                }
                catch
                {
                    try
                    {
                        string sourcePath = seleccion;
                        string targetPath = correccion+"\\"+nombre;
      
                        
                        foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                        {
                            Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                        }

                        
                        foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                        {
                            File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                        }
                        V_copiar = false;
                    }
                    catch
                    {
                        MessageBox.Show("no entra");
                    }
                }
            }
            if (V_mover)
            {
                try
                {
                    File.Move(@seleccion, @correccion + "\\" + nombre);
                    V_mover = false;
                }
                catch
                {
                    try
                    {
                        Directory.Move(@seleccion, @correccion + "\\" + nombre);
                        V_mover = false;
                    }
                    catch
                    {

                    }
                        
                   
                }
            }
           
        }

        private void moverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_mover = true;
            seleccion = correccion;
            nombre = currentlyselectedItemName;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               
                File.Delete(correccion);
            }
            catch
            {
                try
                {
                    Directory.Delete(correccion, true);
                }
                catch
                {

                }
            }
           
            
        }

        private void renombrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chage_name d = new chage_name();
            d.ShowDialog();

                try
                {
                
                    File.Copy(correccion, $"{filePath}\\{Dato.valor}");
                    File.Delete(correccion);
                    V_copiar = false;
                }
                catch
                {
                try
                {
                    Directory.Move(correccion, $"{filePath}\\{Dato.valor}");
                }

                catch
                {
                    MessageBox.Show("no entra");
                }
                }
            
            
            }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
