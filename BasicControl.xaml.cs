using MyResumeOfWPF.PDO;
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

namespace MyResumeOfWPF
{
    /// <summary>
    /// BasicControl.xaml 的交互逻辑
    /// </summary>
    public partial class BasicControl : UserControl
    {
        public BasicControl()
        {
            InitializeComponent();
        }
        private BasicinfoRow mybasicinfo;

        public BasicinfoRow Mybasicinfo
        {
            get { return mybasicinfo; }
            set 
            {
                Myname = value.NameColumn;
                Address = value.AddressColumn;
                Age = value.AgeColumn;
                Phone = value.PhonenumberColumn;
                Email = value.EmailColumn;
                Expe = value.ExperienceColumn;
            }
        }

        public BasicControl(BasicinfoRow inputbasicinfo)
        {
            InitializeComponent();
            Mybasicinfo = inputbasicinfo;
        }

        public string Myname
        {
            get { return (string)GetValue(MynameProperty); }
            set { SetValue(MynameProperty, value); }
        }
        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        public static DependencyProperty MynameProperty =
            DependencyProperty.Register("Myname", typeof(string), typeof(BasicControl), 
                new PropertyMetadata("默认值"));

        public string Age
        {
            get { return (string)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Age.  This enables animation, styling, binding, etc...
        public static DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(string), typeof(BasicControl), 
                new PropertyMetadata("默认值"));

        public string Expe
        {
            get { return (string)GetValue(ExpeProperty); }
            set { SetValue(ExpeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Expe.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ExpeProperty =
            DependencyProperty.Register("Expe", typeof(string), typeof(BasicControl), 
                new PropertyMetadata("默认值"));



        public string Phone
        {
            get { return (string)GetValue(PhoneProperty); }
            set { SetValue(PhoneProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Phone.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PhoneProperty =
            DependencyProperty.Register("Phone", typeof(string), typeof(BasicControl), 
                new PropertyMetadata("默认值"));



        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Email.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register("Email", typeof(string), typeof(BasicControl), 
                new PropertyMetadata("默认值"));



        public string Address
        {
            get { return (string)GetValue(AddressProperty); }
            set { SetValue(AddressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Address.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AddressProperty =
            DependencyProperty.Register("Address", typeof(string), typeof(BasicControl), 
                new PropertyMetadata("默认地址"));

    }
}
