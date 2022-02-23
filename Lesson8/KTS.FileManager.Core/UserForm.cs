using System.Collections;

namespace KTS.FileManager.Core
{
    public abstract class UserForm
    {
        private int _width;
        private int _height;
        private bool _isVisible;
        protected string _currentPath;

        public abstract string CurrentPath { get; set; }

        public int Width 
        {
            get
            {
                return _width;
            }
            set
            {

                _width = value;
            }
        }

        public int Height 
        {
            get
            {
                return _height;
            }
            set
            {

                _height = value;
            }
        }

        public bool IsVisible
        {
            get { return _isVisible; }
            set { _isVisible = value; }
        }
        
        /// <summary>
        /// Запуск основоного окна
        /// </summary>
        public abstract void ShowWindow(int width, int height);

        /// <summary>
        /// Запуск окна с доступными командами
        /// </summary>
        public abstract string ShowWindowMenu();

        /// <summary>
        /// Вывести информацию о выполняемой команде
        /// </summary>      
        public abstract string ShowInfo(IUserCommand command);

        /// <summary>
        /// Вывести информацию об ошибке
        /// </summary>
        public abstract void ShowError(string str);

        /// <summary>
        /// Вывести результат выполнения команды
        /// </summary>
        public abstract void ShowResult(IEnumerable results);

        /// <summary>
        /// Вывод дополнительного сообщения с возвратом ввода с клавиатуры
        /// </summary>
        public abstract string ShowEvantMessage(string str);
        
    }
}
