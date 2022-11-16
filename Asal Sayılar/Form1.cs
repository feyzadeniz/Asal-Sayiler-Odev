using Accessibility;

namespace Asal_Sayılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            //6 haneli sayılarda çalıştı.
            long sayac = 0;
            string no = textBox_tc.Text;
            long no1 = long.Parse(no);

            for(long sayi=2;sayi<=no1; sayi++)
            {
                long kontrol = 0;
                for(long i =2; i<sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol = i;
                        break;
                    }


                }
                if(kontrol == 0)
                {
                    listBox1.Items.Add(sayi);
                    sayac++;

                }


            }

            
            

        }

        private void label_asal_Click(object sender, EventArgs e)
        {
           

        }
    }
}