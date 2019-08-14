pipeline
{
	agent any
	parameters
	{

		string(name: 'GIT_HTTPS_PATH', 
		defaultValue: 'https://github.com/tavisca-bmohan/Web-API.git', 
		description: '')

		string(name: 'SOLUTION_FILE', 
		defaultValue: 'WebAPI.sln', 
		description: '')

		string(name: 'TEST_PROJ_PATH', 
		defaultValue: 'WebAPITest/WebAPITests.csproj', 
		description: '')


	}
	stages
	{
		stage('Build')
		{
				sh 'dotnet restore ${SOLUTION_FILE} --source https://api.nuget.org/v3/index.json
				sh 'dotnet build  ${SOLUTION_FILE} -p:Configuation=release -v:n'
		}

		stage('Test')
		{
			sh 'dotnet test ${TEST_PROJ_PATH}'
		}
	}
}