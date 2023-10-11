SonarScanner.MSBuild.exe begin /k:"PracticeProject" /d:sonar.login="admin" /d:sonar.password="admin"
MSBuild.exe AyazPractice.sln /t:Rebuild
SonarScanner.MSBuild.exe end /d:sonar.login="admin" /d:sonar.password="admin"