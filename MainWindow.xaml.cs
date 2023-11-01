using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GA_Hafsa_RTB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //part 1 - display a message
        private void btnDisplayMessage_Click(object sender, RoutedEventArgs e)
        {
            //button display message from txtDisplay to 
            //rtbDisplay replacing the message
            string message = txtSingleMessageDisplay.Text;

            rtbDisplay.Text = message;

        } //btnDisplayMessage_Click


        //part 2 - append a text
        private void btnAppend_Click(object sender, RoutedEventArgs e)
        {
            //appends message from textbox to the rtbDisplay
            string messageToappend = txtAppendMessage.Text;

            //doing \n to newline
            rtbDisplay.Text += "\n" + messageToappend;

        } //btnAppend_Click



        //part 3 - display text from one rtb to another rtb
        private void btnAppendNewRtb_Click(object sender, RoutedEventArgs e)
        {
            string fullMessage = rtbDisplay.Text;

            rtbNewRtb.Text += "\n" + fullMessage + "\n";

        } //btnAppendNewRTB



        //part 4 - clear the text
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            rtbNewRtb.Text = "";
            rtbDisplay.Text = "";
        }
    } //class


} //namespace
