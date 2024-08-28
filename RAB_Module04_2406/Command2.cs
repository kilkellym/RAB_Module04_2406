namespace RAB_Module04_2406
{
	[Transaction(TransactionMode.Manual)]
	public class Command2 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			// Revit application and document variables
			UIApplication uiapp = commandData.Application;
			UIDocument uidoc = uiapp.ActiveUIDocument;
			Document doc = uidoc.Document;

			// Your code goes here
			TaskDialog.Show("Test", "This is Command 2");

			return Result.Succeeded;
		}

	}

}
