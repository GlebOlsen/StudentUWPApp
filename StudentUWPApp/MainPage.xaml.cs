﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StudentUWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Student Student1 = new Student("Gleb",123,00001);
            Student Student2 = new Student("John",124,00002);
            Student Student3 = new Student("Simon",125,00003);
            Student Student4 = new Student("Thais",126,00004);
            Student Student5 = new Student("Hassan",127,00005);
            Student Student6 = new Student("Jeppe", 128,00006);

            OC_list_Students.Add(Student1);
            OC_list_Students.Add(Student2);
            OC_list_Students.Add(Student3);
            OC_list_Students.Add(Student4);
            OC_list_Students.Add(Student5);
            OC_list_Students.Add(Student6);

        }
        ObservableCollection<Student> OC_list_Students = new ObservableCollection<Student>();
    }
}
