using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UjianAkhirSemester
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    class program
    {
        public Node ROOT;
        public program()
        {
            ROOT = null;
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        public void insert(string element)
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)
            {
                Console.WriteLine("\nId_Barang");
                Console.WriteLine("\nNama_Barang");
                Console.WriteLine("\nJenis_Barang");
                Console.WriteLine("\nHarga_Barang");
                Console.WriteLine("");
                return;
            }
            else
            {
                tmp = new Node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("\nBarang Yang Baru Saja Masuk");
                Console.WriteLine("Id_2000 Kulkas 2 pintu Rp.500.000");
                Console.WriteLine("Id_2001 Kipas Angin Rp.250.000");
                Console.WriteLine("Id_2002 Speaker Rp.50.000");
                Console.WriteLine("Elektronik");
                Console.WriteLine("");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.leftchild);
                Console.Write(ptr.info + "");
                inorder(ptr.rightchild);
            }
        }
        public void preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("\nBarang Yang Tidak Tersedia");
                Console.WriteLine("Id_2230");
                Console.WriteLine("Lampu Led");
                Console.WriteLine("Elektronik");
                Console.WriteLine("Rp.75.000");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + "");
                preorder(ptr.leftchild);
                preorder(ptr);
            }
        }
        public void postorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("\nBarang Yang Tersedia");
                Console.WriteLine("Id_110 AC Rp.1.500.000");
                Console.WriteLine("Id_111 Pompa Galon Rp.15.000");
                Console.WriteLine("Elektronik");
                Console.WriteLine("");
                return;
            }
            if (ptr != null)
            {
                postorder(ptr.leftchild);
                postorder(ptr.rightchild);
                Console.WriteLine(ptr.info + "");
            }
        }
        static void Main(string[] args)
        {
            program x = new program();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Implementasi insert option");
                Console.WriteLine("2. Perform inorder traversal");
                Console.WriteLine("3. Perform preorder traversal");
                Console.WriteLine("4. Perform postorder traversal");
                Console.WriteLine("5. Exit");
                Console.WriteLine("\nEnter your choice (1-5) :");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.WriteLine("\nId_Barang");
                            Console.WriteLine("\nNama_Barang");
                            Console.WriteLine("\nJenis_Barang");
                            Console.WriteLine("\nHarga_Barang");
                            Console.Write("");
                        }
                        break;
                    case '2':
                        {
                            x.inorder(x.ROOT);
                        }
                        break;
                    case '3':
                        {
                            x.preorder(x.ROOT);
                        }
                        break;
                    case '4':
                        {
                            x.postorder(x.ROOT);
                        }
                        break;
                    case '5':
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                }
            }
        }
    }
}

//*Saya Menggunakan Algoritma Binary BinarySearchTree_128, Saya memilih algoritma ini karena saya mengikuti intruksi dari soal untuk membuat pengurutan data yang diinginkan indri simpan yaitu Id_Barang, Nama Barang, Jenis Barang 
//dan algorithma BinarySearchTree menurut saya sangat sesuai karena ada algoritma inorder,preorder,dan postorder Traversal
//kedalaman struktur adalah 5
//Metode InOrder
//*FRONT dan REAR