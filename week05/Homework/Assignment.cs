using System;
using System.Security.Cryptography.X509Certificates;
public class Assignment{
        protected string _studentName = "Samuel Bennett";
        private string _topic = "Multiplication";

        public Assignment(){
            _studentName = "Anonymous";
            _topic = "unknown";
        }

        public Assignment(string studentName, string topic){
            _studentName = studentName;
            _topic = topic;
        }

        public string GetSummary(){
            return $"{_studentName} - {_topic}";
        }

        public string GetStudentName(){
            return _studentName;
        }

        public void SetStudentName(string studentName){
            _studentName = studentName;
        }

        public string GetTopic(){
            return _topic;
        }

        public void SetTopic(string topic){
            _topic = topic;
        }
    }