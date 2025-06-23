# ==== CONFIG ====
$projectName = "phuvo1104/PRN212-SE1855"
$token = "c9lKeLYxSrQb5JaY3DATiQ"
$email = "phuvo1104@gmail.com"
$covPath = "D:\cov-analysis-win64-2024.6.1\bin"
$sourceDir = "D:\VisualStudioSRC\prn212"
$solutionFile = "PRN212-SE1855.sln"
$outputTgz = "$sourceDir\coverity_result.tgz"

# ==== ENV ====
$env:Path += ";$covPath"
cd $sourceDir

# ==== CLEAN & BUILD ====
msbuild $solutionFile /t:Clean
cov-build --dir cov-int msbuild $solutionFile /t:Rebuild
# ==== NÉN FILE ====
tar -czvf $outputTgz cov-int

