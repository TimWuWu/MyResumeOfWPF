using MyResumeOfWPF.PDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// SkillUIControl.xaml 的交互逻辑
    /// </summary>
    public partial class SkillUIControl : UserControl
    {
        private SkillRow skillforUI;
        
        public SkillRow SkillForUI
        {
            get { return skillforUI; }
            set 
            { 
                skillforUI = value;
                ComponentOne = skillforUI.ComponentOneColumn;
                ComponentTwo= skillforUI.ComponentTwoColumn;
                ComponentThree= skillforUI.ComponentThreeColumn;
                ComponentFour= skillforUI.ComponentFourColumn;
                Topic= skillforUI.TopicColumn;
            }
        }

        //从指定的数据源获取数据
        public SkillUIControl()
        {
            InitializeComponent();
                            
        }
        //数据注入，从控件的上层得到数据
        public SkillUIControl(SkillRow input)
        {
            SkillForUI = input;
            InitializeComponent();
        }


        public string ComponentOne
        {
            get { return (string)GetValue(ComponentOneProperty); }
            set { SetValue(ComponentOneProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ComponentOne.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComponentOneProperty =
            DependencyProperty.Register("ComponentOne", typeof(string), typeof(SkillUIControl), 
                new PropertyMetadata("default"));

        public string ComponentTwo
        {
            get { return (string)GetValue(ComponentTwoProperty); }
            set { SetValue(ComponentTwoProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ComponentTwo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComponentTwoProperty =
            DependencyProperty.Register("ComponentTwo", typeof(string), typeof(SkillUIControl), 
                new PropertyMetadata("default"));

        public string ComponentThree
        {
            get { return (string)GetValue(ComponentThreeProperty); }
            set { SetValue(ComponentThreeProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ComponentThree.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComponentThreeProperty =
            DependencyProperty.Register("ComponentThree", typeof(string), typeof(SkillUIControl), 
                new PropertyMetadata("default"));

        public string ComponentFour
        {
            get { return (string)GetValue(ComponentFourProperty); }
            set { SetValue(ComponentFourProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ComponentFour.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComponentFourProperty =
            DependencyProperty.Register("ComponentFour", typeof(string), typeof(SkillUIControl), 
                new PropertyMetadata("default"));

        public string Topic
        {
            get { return (string)GetValue(TopicProperty); }
            set { SetValue(TopicProperty, value); }
        }
        // Using a DependencyProperty as the backing store for Topic.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TopicProperty =
            DependencyProperty.Register("Topic", typeof(string), typeof(SkillUIControl), 
                new PropertyMetadata("default"));


    }
}
