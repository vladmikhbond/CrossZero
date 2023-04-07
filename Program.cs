using CrossZero.Controllers;
using CrossZero.Views;

Model model = new Model(size: 10, winSize: 5);
View view = new View(model);
Controller controller = new Controller(model, view);

controller.Run();

