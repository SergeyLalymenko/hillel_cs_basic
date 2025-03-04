//Створіть консольний додаток на мові C#, який реалізує функціональність списку справ. Ваш список справ повинен мати наступні можливості:
//Додавання справи: Напишіть функцію, яка додає нову справу до списку. Користувач повинен мати можливість ввести назву справи.
//Виведення всіх справ: Реалізуйте функцію, яка виводить на екран усі справи зі списку.
//Відмітка про виконання: Додайте можливість позначити справу як виконану. Користувач повинен ввести номер справи, яку він хоче відмітити.
//Видалення справи: Напишіть функцію, яка дозволяє видалити справу зі списку. Користувач повинен ввести номер справи для видалення.

namespace lesson_13
{
    internal class Program
    {
        public static List<Todo> todos = [];

        static void Main()
        {
            todos.Add(CreateNewTodo());
            todos.Add(CreateNewTodo());
            PrintTodos();
            ToggleTodo();
            PrintTodos();
            DeleteTodo();
            PrintTodos();
        }

        public static Todo CreateNewTodo()
        
        {
            string text;

            do
            {
                Console.WriteLine("Enter todo text:");
                text = Console.ReadLine();
            } while (text == null);

            return new Todo(text, GetNextId());
        }

        public static int GetNextId()
        {
            if (todos.Count == 0)
            {
                return 1;
            }

            return todos.Max((todo) => todo.Id) + 1;
        }

        public static void PrintTodos()

        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No todos found.");
                return;
            }

            foreach (Todo todo in todos)
            {
                Console.WriteLine($"Id: {todo.Id}, todo: {todo.Text}, is done: {todo.IsDone}.");
            }
        }

        public static void ToggleTodo()
        {
            int id = GetUserInputId();

            Todo todo = todos.FirstOrDefault((todo) => todo.Id == id);
            if (todo == null)
            {
                Console.WriteLine("Todo not found.");
                return;
            }

            todo.IsDone = !todo.IsDone;
        }

        public static void DeleteTodo()
        {
            int id = GetUserInputId();

            Todo todo = todos.FirstOrDefault((todo) => todo.Id == id);
            if (todo == null)
            {
                Console.WriteLine("Todo not found.");
                return;
            }

            todos = todos.Where((todo) => todo.Id != id).ToList();
        }

        public static int GetUserInputId()
        {
            int id;

            do
            {
                Console.WriteLine("Enter todo id:");
            } while (!int.TryParse(Console.ReadLine(), out id));

            return id;
        }
    }
}
