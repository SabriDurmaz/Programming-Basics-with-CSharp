string architectName = Console.ReadLine();

int numberOfProjects = int.Parse(Console.ReadLine());

int hoursPerProject = 3;

int totalHours = numberOfProjects * hoursPerProject;

Console.WriteLine($"The architect {architectName} will need {totalHours} hours to complete {numberOfProjects} project/s.");