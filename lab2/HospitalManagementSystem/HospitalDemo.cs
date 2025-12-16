using System;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            Hospital hospital = new Hospital();

            // Лікарі
            var d1 = new Doctor(1, "Іваненко Олег", "терапевт");
            var d2 = new Doctor(2, "Петренко Марія", "хірург");
            var d3 = new Doctor(3, "Сидоренко Андрій", "кардіолог");

            hospital.AddDoctor(d1);
            hospital.AddDoctor(d2);
            hospital.AddDoctor(d3);

            // Пацієнти
            var p1 = new Patient(1, "Коваленко Тарас", 28);
            var p2 = new Patient(2, "Мельник Олена", 35);
            var p3 = new Patient(3, "Шевченко Ірина", 42);
            var p4 = new Patient(4, "Бондар Сергій", 19);

            hospital.RegisterPatient(p1);
            hospital.RegisterPatient(p2);
            hospital.RegisterPatient(p3);
            hospital.RegisterPatient(p4);

            // Палати
            var r101 = new HospitalRoom(101, 2);
            var r102 = new HospitalRoom(102, 1);
            var r103 = new HospitalRoom(103, 2);

            hospital.CreateRoom(r101);
            hospital.CreateRoom(r102);
            hospital.CreateRoom(r103);

            // Госпіталізація
            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 101); // переповнена
            hospital.HospitalizePatient(3, 102);
            hospital.HospitalizePatient(999, 101); // не знайдений
            hospital.HospitalizePatient(4, 999);   // палата не знайдена

            // Медичні записи
            hospital.AddMedicalRecord(new MedicalRecord(p1, d1, DateTime.Today.AddDays(-2), "Огляд, призначено аналізи"));
            hospital.AddMedicalRecord(new MedicalRecord(p1, d2, DateTime.Today.AddDays(-1), "Консультація хірурга, рекомендації"));
            hospital.AddMedicalRecord(new MedicalRecord(p3, d3, DateTime.Today, "ЕКГ, призначено лікування"));

            // Історія пацієнта
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            // Статистика
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
