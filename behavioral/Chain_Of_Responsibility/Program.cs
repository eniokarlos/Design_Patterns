using Chain_of_responsibility;

ProjectManager projectManager = new ProjectManager();
TeamSupervisor teamSupervisor = new TeamSupervisor();
TeamRH rh = new TeamRH();

projectManager.NextAuthorizer(teamSupervisor);
teamSupervisor.NextAuthorizer(rh);

projectManager.AuthorizeLicense("John", 9);
projectManager.AuthorizeLicense("Carl", 14);
projectManager.AuthorizeLicense("Mary", 30);
projectManager.AuthorizeLicense("Amanda", 40);