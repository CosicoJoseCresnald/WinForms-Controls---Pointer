using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.Reflection;

namespace WinForms_Controls___Pointers1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            defaultPointerBtn.Cursor = Cursors.Default;
            handPointerBtn.Cursor = Cursors.Hand;
            helpPointerBtn.Cursor = Cursors.Help;
            customPointerBtn.Cursor = new Cursor("CustomCursor.cur");
        }
        //WINDOWS FORMS CONTROLS - POINTERS
        /*
         Mouse pointer, or cursor is used to navigate to the computer.
         Controlled by a device, such as mouse ,tablet or trackball,
         it is also used to point on where the user would like to click in
         order to interact with it.Aside from the default pointers,
         there are other pointers that are used in order to specify
         on what interaction does an object implies.


        All of the controls have a cursor property
        Custom cursors must be on a .cur file format
        */

        //POINTER ACCESS
        //HIDES THE POINTER WHEN MOUSE ENTERS/LEAVES THE CONTROL
        private void hidePointerBtn_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void hidePointerBtn_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        //CHANGE POINTER POSITION
        private void switchPointerPosition1_Click_1(object sender, EventArgs e)
        {
            //moves the cursor into a certain control
            Cursor.Position = PointToScreen(switchPointerPosition2.Location);
            //moves the pointer into a certain coordinate shonw in the screen
            //Cursor.Position = new Point(325, 600);
        }

        private void switchPointerPosition2_Click_1(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(switchPointerPosition1.Location);
        }

        //CHANGE POINTER
        //default
        private void defaultPointerBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        //hand
        private void handPointerBtn_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        //help
        private void helpPointerBtn_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Help;
        }
        //custom cursor
        private void customPointerBtn_Click_1(object sender, EventArgs e)
        {
            Cursor = new Cursor("CustomCursor.cur");
        }
        //image cursor
        private void imagePointerBtn_Click(object sender, EventArgs e)
        {
            //file location path may vary
            //only jpg files can be used for image format
            Bitmap bitmap1 = new Bitmap(new Bitmap("F:\\vsc codes\\WinForms Controls - Pointers\\WinForms Controls - Pointers1\\image.jpg"), 70, 70);
            imagePointerBtn.Cursor = new Cursor(bitmap1.GetHicon());
            Cursor = new Cursor(bitmap1.GetHicon());
        }

        //REFERENCES
        // Cursor Class - https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.cursor?view=windowsdesktop-8.0
        // How to Manage Mouse Pointer - https://learn.microsoft.com/en-us/dotnet/desktop/winforms/input-mouse/how-to-manage-cursor-pointer?view=netdesktop-8.0#changing-the-mouse-pointer
        // Pointer - C# Windows Forms Control - https://youtu.be/zKb79hEqaAw?si=w9m-WMlIuGU0kZWp 
        // C# move mouse cursor - https://stackoverflow.com/questions/55061384/c-sharp-move-mouse-cursor-to-a-specific-position-on-screen-for-windows-10-64bit
        //GitHub Link - https://github.com/CosicoJoseCresnald/WinForms-Controls---Pointer.git
    }
}
