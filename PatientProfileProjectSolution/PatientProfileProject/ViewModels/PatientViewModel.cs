﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;
using PatientProfileProject.Models;

namespace PatientProfileProject.ViewModels
{
    public class PatientViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        private Patient _patient;

      
        public Patient Patients
        {
            get { return _patient; }
            set
            {
                _patient = value; onPropertyChanged(nameof(Patients));
            }
        }


        public ICommand RegisterCommand {  get; }
        public ICommand BackupCommand {  get; }

        public PatientViewModel()
        {
            Patients = new Patient
            {
                PatientName = "",
                PatientId = "",
                DOB = DateTime.Now,
                Sex = "",
                Place = "",
                ScheduleDate = DateTime.Now,

            };


            RegisterCommand = new RelayCommand(Register);
            BackupCommand = new RelayCommand(Backup);


        }

        private void Register()
        {
            try
            {

                Patient newPatient = new Patient
                {
                    PatientName = Patients.PatientName,
                    PatientId = Patients.PatientId,
                    DOB = Patients.DOB,
                    Sex = Patients.Sex,
                    Place = Patients.Place,
                    ScheduleDate = Patients.ScheduleDate,
                };

                var result = MessageBox.Show(messageBoxText: "Are you sure to create?",
                    caption: "Confirm",
                    button: MessageBoxButton.YesNo,
                    icon: MessageBoxImage.Question);
                if (result != MessageBoxResult.Yes)
                {
                    return;
                }

                var xmlFilePath = Path.Combine("Data/Patient Details", $"{newPatient.PatientId}_Details.xml");

                using (var writer = new StreamWriter(xmlFilePath))
                {
                    var serializer = new XmlSerializer(typeof(Patient));
                    serializer.Serialize(writer, newPatient);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Backup()
        {
            try
            {
                string sourceDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Patient Details");
                string destinationDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "History");

               
                foreach (var filePath in Directory.GetFiles(sourceDirectory))
                {
                    string fileName = Path.GetFileName(filePath);
                    string destinationFilePath = Path.Combine(destinationDirectory, fileName);
                    File.Move(filePath, destinationFilePath);
                }

                MessageBox.Show("Backup completed successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
