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
    /// EducationUIControl.xaml 的交互逻辑
    /// </summary>
    public partial class EducationUIControl : UserControl
    {
        private EducationRow educationrowinput;
        public EducationRow EducationrowInput
        {
            get { return educationrowinput; }
            set
            {
                educationrowinput = value;
                Stage = educationrowinput.StageColumn;
                School = educationrowinput.SchoolnameColumn;
                Majoy = educationrowinput.MajoyColumn;
                Start = educationrowinput.StartColumn;
                Period = educationrowinput.PeriodColumn;
            }
        }
        public EducationUIControl()
        {           
            InitializeComponent();           
        }
        public EducationUIControl(EducationRow input)
        {
            EducationrowInput = input;
            InitializeComponent();
        }

        public string Stage
        {
            get { return (string)GetValue(StageProperty); }
            set { SetValue(StageProperty, value); }
        }
        // Using a DependencyProperty as the backing store for Stage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StageProperty =
            DependencyProperty.Register("Stage", typeof(string), typeof(EducationUIControl), 
                new PropertyMetadata("大学"));

        public string School
        {
            get { return (string)GetValue(SchoolProperty); }
            set { SetValue(SchoolProperty, value); }
        }
        // Using a DependencyProperty as the backing store for School.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SchoolProperty =
            DependencyProperty.Register("School", typeof(string), typeof(EducationUIControl), 
                new PropertyMetadata("我的大学"));

        public string Majoy
        {
            get { return (string)GetValue(MajoyProperty); }
            set { SetValue(MajoyProperty, value); }
        }
        // Using a DependencyProperty as the backing store for Majoy.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MajoyProperty =
            DependencyProperty.Register("Majoy", typeof(string), typeof(EducationUIControl), 
                new PropertyMetadata("my majoy"));

        public string Start
        {
            get { return (string)GetValue(StartProperty); }
            set { SetValue(StartProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Start.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StartProperty =
            DependencyProperty.Register("Start", typeof(string), typeof(EducationUIControl), 
                new PropertyMetadata("date of start"));

        public string Period
        {
            get { return (string)GetValue(PeriodProperty); }
            set { SetValue(PeriodProperty, value); }
        }
        // Using a DependencyProperty as the backing store for Period.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PeriodProperty =
            DependencyProperty.Register("Period", typeof(string), typeof(EducationUIControl), 
                new PropertyMetadata("四年"));


    }
}
