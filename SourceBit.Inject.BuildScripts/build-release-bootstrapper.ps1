# Bootstrapper for building

Import-Module ".\packages\psake-4.1.0\psake.psm1"

Invoke-psake -buildFile ".\SourceBit.Inject.BuildScripts\build-releasepsake-build.ps1"