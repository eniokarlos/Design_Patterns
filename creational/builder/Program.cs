using builder;

Director director = new Director();

NotebookBuilder notebookBuilder = new NotebookBuilder();
DesktopBuilder desktopBuilder = new DesktopBuilder();

director.Build(notebookBuilder);
director.Build(desktopBuilder);