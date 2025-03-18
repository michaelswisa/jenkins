pipeline {
    agent any
    environment {
        DOTNET_VERSION = '6.0'
    }
    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/michaelswisa/jenkins.git'
            }
        }
        stage('Build') {
            steps {
                script {
                    sh 'dotnet build jenkins/jenkins.csproj'
                }
                script {
                    sh 'dotnet build jenkins/jenkins.tests/jenkins.tests.csproj'
                }
            }
        }
        stage('Test') {
            steps {
                script {
                    sh 'dotnet test jenkins/jenkins.tests/jenkins.tests.csproj'
                }
            }
        }
        stage('Run Application') {
            steps {
                script {
                    sh 'dotnet run --project jenkins/jenkins.csproj'
                }
            }
        }
    }
    post {
        success {
            echo 'Build succeeded!'
        }
        failure {
            echo 'Build failed!'
        }
    }
}
