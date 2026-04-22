using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using LinkedListLibrary;
using SetDemo;

namespace MySetWpf
{
    public partial class MainWindow : Window
    {
        MySet<Student> _men = new MySet<Student>();
        MySet<Student> _women = new MySet<Student>();
        MySet<Student> _reading = new MySet<Student>();
        MySet<Student> _writing = new MySet<Student>();
        MySet<Student> _arithmetic = new MySet<Student>();
        Dictionary<string, MySet<Student>> allSets = new Dictionary<string, MySet<Student>>();

        public MainWindow()
        {
            Student james = new Student(1, "James", Gender.Male);
            Student robert = new Student(2, "Robert", Gender.Male);
            Student john = new Student(3, "John", Gender.Male);
            Student mark = new Student(4, "Mark", Gender.Male);
            Student otherMark = new Student(5, "Mark", Gender.Male);
            _men.AddRange(new Student[] { james, robert, john, mark, otherMark });

            Student liz = new Student(6, "Liz", Gender.Female);
            Student amy = new Student(7, "Amy", Gender.Female);
            Student eve = new Student(8, "Eve", Gender.Female);
            _women.AddRange(new Student[] { liz, amy, eve });

            _reading.AddRange(new Student[] { james, robert, liz });
            _writing.AddRange(new Student[] { robert, mark, amy, liz });
            _arithmetic.AddRange(new Student[] { john, mark, otherMark, amy });

            allSets.Add("Men", _men);
            allSets.Add("Women", _women);
            allSets.Add("Reading", _reading);
            allSets.Add("Writing", _writing);
            allSets.Add("Arithmetic", _arithmetic);

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string name in allSets.Keys)
            {
                LeftSet.Items.Add(name);   
                RightSet.Items.Add(name);  
            }

            Operation.Items.Add("Union");
            Operation.Items.Add("Intersection");
            Operation.Items.Add("Difference");
            Operation.Items.Add("Symmetric diff");
        }

        private void leftSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LeftMember.Items.Clear(); 

            if (LeftSet.SelectedItem != null)
            {
                string name = LeftSet.SelectedItem.ToString();
                DisplaySetData(GetSetByName(name), LeftMember);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private MySet<Student> GetSetByName(string name)
        {
            if (allSets.ContainsKey(name))
                return allSets[name];
            return null;
        }

        private void DisplaySetData(MySet<Student> set, ListBox listBox)
        {
            if (set == null) return;

            foreach (Student student in set)
            {
                listBox.Items.Add(student.ToString());
            }
        }
    }
}