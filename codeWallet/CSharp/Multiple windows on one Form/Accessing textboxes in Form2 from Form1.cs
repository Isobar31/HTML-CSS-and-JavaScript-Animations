// Codes on Form1

public partial class Form1 : Form
    {
        public static string passingText;//This variable conveys a single value to a single textbox of the Form2.
        public static string passing2Text;//This variable conveys a single value to a single textbox of the Form2.

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            passingText = txtNumber1.Text;
            passing2Text = txtNumber2.Text;
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
    
    
    
    
    
    // Codes on form2
    public partial class Form2 : Form
    {

       
        public Form2()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            txtResult.Text = Form1.passingText;
            txtResult2.Text = Form1.passing2Text;

        }
