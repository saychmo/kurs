using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kurs
{
    public static class ProgramJSON
    {
        private const string FilePath = "employees.json";

        public static void SaveEmployees(List<Employee> employees)
        {
            string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static List<Employee> LoadEmployees()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<Employee>>(json);
            }
            return new List<Employee>(); // Возвращаем пустой список, если файл не существует
        }
        public static void ClearEmployees()
        {
            // Записываем пустой массив в файл employees.json
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(new List<Employee>(), Formatting.Indented));
        }

        private static string filePath = "projects.json";

        public static void SaveProjects(List<Project> projects)
        {
            string jsonData = JsonConvert.SerializeObject(projects, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        public static List<Project> LoadProjects()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Project>>(jsonData) ?? new List<Project>();
            }
            return new List<Project>();
        }
    }
}

