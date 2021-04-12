$1 -projectPath ./Asteroids -batchmode -testPlatform playmode -runTests -debugCodeOptimization -enableCodeCoverage -coverageResultsPath ./coverage-results -coverageOptions "generateAdditionalMetrics;assemblyFilters:+<user>"
curl -s https://codecov.io/bash | bash -s -- -c -t $2 -F playmode -X search -f Asteroids/coverage-results/Asteroids-opencov/PlayMode/TestCoverageResults*.xml
