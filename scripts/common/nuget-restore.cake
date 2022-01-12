
//---------------------------------------------------------------------------------------
Task("nuget-restore")
    .IsDependentOn("nuget-restore-externals")
    .IsDependentOn("nuget-restore-libs")
    .IsDependentOn("nuget-restore-tests")
    .Does
    (
        () =>
        {
            return;
        }
    );

Task("nuget-restore-externals")
    .Does
    (
        () =>
        {
            FilePathCollection files = null;

            files = GetFiles("./externals/**/source/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
        		NuGetRestore
                    (
                        file, 
                        new NuGetRestoreSettings 
                        { 
                            PackagesDirectory = $"{file.GetDirectory()}/packages"
                        } 
                    );
            }

            files = GetFiles("./externals-submodules/**/source/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
        		NuGetRestore
                    (
                        file, 
                        new NuGetRestoreSettings 
                        { 
                            PackagesDirectory = $"{file.GetDirectory()}/packages"
                        } 
                    );
            }

            files = GetFiles("./externals/**/source/*.csproj");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
        		NuGetRestore
                    (
                        file, 
                        new NuGetRestoreSettings 
                        { 
                            PackagesDirectory = $"{file.GetDirectory()}/packages"
                        } 
                    );
            }

            files = GetFiles("./externals-submodules/**/source/*.csproj");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
        		NuGetRestore
                    (
                        file, 
                        new NuGetRestoreSettings 
                        { 
                            PackagesDirectory = $"{file.GetDirectory()}/packages"
                        } 
                    );
            }

            return;
        }
    );

Task("nuget-restore-libs")
    .Does
    (
        () =>
        {
            FilePathCollection files = null;
            files = GetFiles("./source/**/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
        		NuGetRestore
                    (
                        file, 
                        new NuGetRestoreSettings 
                        { 
                            PackagesDirectory = $"{file.GetDirectory()}/packages"
                        } 
                    );
            }

            files = GetFiles("./source/**/*.csproj");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
        		NuGetRestore
                    (
                        file, 
                        new NuGetRestoreSettings 
                        { 
                            PackagesDirectory = $"{file.GetDirectory()}/packages"
                        } 
                    );
            }

            return;
        }
    );

Task("nuget-restore-samples")
    .Does
    (
        () =>
        {
            FilePathCollection files = null;
            files = GetFiles("./samples/**/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
        		NuGetRestore
                    (
                        file, 
                        new NuGetRestoreSettings 
                        { 
                            PackagesDirectory = $"{file.GetDirectory()}/packages"
                        } 
                    );
            }

            files = GetFiles("./samples/**/*.csproj");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
        		NuGetRestore
                    (
                        file, 
                        new NuGetRestoreSettings 
                        { 
                            PackagesDirectory = $"{file.GetDirectory()}/packages"
                        } 
                    );
            }

            return;
        }
    );

Task("nuget-restore-tests")
    .Does
    (
        () =>
        {
            FilePathCollection files = null;

            files = GetFiles("./tests/**/*.sln");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
        		NuGetRestore
                    (
                        file, 
                        new NuGetRestoreSettings 
                        { 
                            PackagesDirectory = $"{file.GetDirectory()}/packages"
                        } 
                    );
            }

            files = GetFiles("./tests/**/*.csproj");
            foreach(FilePath file in files)
            {
                Information("File: {0}", file);
        		NuGetRestore
                    (
                        file, 
                        new NuGetRestoreSettings 
                        { 
                            PackagesDirectory = $"{file.GetDirectory()}/packages"
                        } 
                    );
            }

            return;
        }
    );

public void RestorePackages(string pattern)
{
	FilePathCollection files = GetFiles(pattern);

	foreach(FilePath file in files)
	{
		NuGetRestore(file, new NuGetRestoreSettings { } );
	}

	return;
}
//---------------------------------------------------------------------------------------
