using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

namespace MachineLearningForKids
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr child, IntPtr newParent);
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        private const int WM_SYSCOMMAND = 274;
        private const int SC_MAXIMIZE = 61488;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTurist_Click(object sender, EventArgs e)
        {
            string exePath = "C:\\Users\\Serdar\\source\\repos\\MachineLearningForKids\\MachineLearningForKids\\Games\\geziBul\\geziBul\\bin\\Debug\\geziBul.exe";
            Process proc = Process.Start(exePath);
            while (proc.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(proc.MainWindowHandle))
            {
                System.Threading.Thread.Sleep(10);
                proc.Refresh();
            }
            proc.WaitForInputIdle();

            SetParent(proc.MainWindowHandle, this.panelGame.Handle);
            SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
        }
        private void btnTitanic_Click(object sender, EventArgs e)
        {
            string exePath = "C:\\Users\\Serdar\\source\\repos\\MachineLearningForKids\\MachineLearningForKids\\Games\\Titanic\\Titanic\\bin\\Debug\\Titanic.exe";
            Process proc = Process.Start(exePath);
            while (proc.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(proc.MainWindowHandle))
            {
                System.Threading.Thread.Sleep(10);
                proc.Refresh();
            }
            proc.WaitForInputIdle();

            SetParent(proc.MainWindowHandle, this.panelGame.Handle);
            SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
        }

        private void btnSortinghat_Click(object sender, EventArgs e)
        {
            string exePath = "C:\\Users\\Serdar\\source\\repos\\MachineLearningForKids\\MachineLearningForKids\\Games\\SortingHat\\SortingHat\\bin\\Debug\\SortingHat.exe";
            Process proc = Process.Start(exePath);
            while (proc.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(proc.MainWindowHandle))
            {
                System.Threading.Thread.Sleep(10);
                proc.Refresh();
            }
            proc.WaitForInputIdle();

            SetParent(proc.MainWindowHandle, this.panelGame.Handle);
            SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string exePath = "C:\\Users\\Serdar\\source\\repos\\MachineLearningForKids\\MachineLearningForKids\\Games\\VirtualPetApp\\VirtualPetApp\\bin\\Debug\\VirtualPetApp.exe";
            Process proc = Process.Start(exePath);
            while (proc.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(proc.MainWindowHandle))
            {
                System.Threading.Thread.Sleep(10);
                proc.Refresh();
            }
            proc.WaitForInputIdle();

            SetParent(proc.MainWindowHandle, this.panelGame.Handle);
            SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string exePath = "C:\\Users\\Serdar\\source\\repos\\MachineLearningForKids\\MachineLearningForKids\\Games\\Bukalemun\\Bukalemun\\bin\\Debug\\Bukalemun.exe";
            Process proc = Process.Start(exePath);
            while (proc.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(proc.MainWindowHandle))
            {
                System.Threading.Thread.Sleep(10);
                proc.Refresh();
            }
            proc.WaitForInputIdle();

            SetParent(proc.MainWindowHandle, this.panelGame.Handle);
            SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
        }

        private void btnFacelock_Click(object sender, EventArgs e)
        {
            string exePath = "C:\\Users\\Serdar\\source\\repos\\MachineLearningForKids\\MachineLearningForKids\\Games\\FaceLock\\FaceLock\\bin\\Debug\\FaceLock.exe";
            Process proc = Process.Start(exePath);
            while (proc.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(proc.MainWindowHandle))
            {
                System.Threading.Thread.Sleep(10);
                proc.Refresh();
            }
            proc.WaitForInputIdle();

            SetParent(proc.MainWindowHandle, this.panelGame.Handle);
            SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
           
            string exePath = "C:\\Users\\Serdar\\source\\repos\\MachineLearningForKids\\MachineLearningForKids\\Games\\schLibrary\\schLibrary\\bin\\Debug\\schLibrary.exe";
            Process proc = Process.Start(exePath);
            while (proc.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(proc.MainWindowHandle))
            {
                System.Threading.Thread.Sleep(10);
                proc.Refresh();
            }
            proc.WaitForInputIdle();

            SetParent(proc.MainWindowHandle, this.panelGame.Handle);
            SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string exePath = "C:\\Users\\Serdar\\source\\repos\\MachineLearningForKids\\MachineLearningForKids\\Games\\MakeMeHappy\\MakeMeHappy\\bin\\Debug\\MakeMeHappy.exe";
            Process proc = Process.Start(exePath);
            while (proc.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(proc.MainWindowHandle))
            {
                System.Threading.Thread.Sleep(10);
                proc.Refresh();
            }
            proc.WaitForInputIdle();

            SetParent(proc.MainWindowHandle, this.panelGame.Handle);
            SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string exePath = "C:\\Users\\Serdar\\source\\repos\\MachineLearningForKids\\MachineLearningForKids\\Games\\NoughtsandCrosses\\NoughtsandCrosses\\bin\\Debug\\NoughtsandCrosses.exe";
            Process proc = Process.Start(exePath);
            while (proc.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(proc.MainWindowHandle))
            {
                System.Threading.Thread.Sleep(10);
                proc.Refresh();
            }
            proc.WaitForInputIdle();

            SetParent(proc.MainWindowHandle, this.panelGame.Handle);
            SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"C:\Users\Serdar\source\repos\MachineLearningForKids\MachineLearningForKids\Games\KiwiorStoat\KiwiorStoat\bin\Debug\KiwiorStoat.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
