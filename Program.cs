using CrossZero.Controllers;
using CrossZero.Views;

Model model = new Model(size: 3, winSize: 3);
View view = new View(model);
Controller controller = new Controller(model, view);

controller.Run();

