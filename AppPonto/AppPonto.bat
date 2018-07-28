ECHO parameter=%1
CD %1
COPY EMC_VitrineRetaguarda.exe temp.exe
C:\"Program Files (x86)"\Microsoft\ILMerge\ILMerge.exe /target:winexe /targetplatform:"v3,C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v3.5" /out:AppPonto.exe temp.exe AppPonto_BLL.dll AppPonto_DAL.dll AppPonto_ENT.dll Microsoft.ReportViewer.Common.dll Microsoft.ReportViewer.ProcessingObjectModel.DLL Microsoft.ReportViewer.WinForms.DLL Microsoft.SqlServer.Types.dll
DEL temp.exe
DEL AppPonto_BLL.dll
DEL AppPonto_DAL.dll
DEL AppPonto_ENT.dll
DEL Microsoft.ReportViewer.Common.dll
DEL Microsoft.ReportViewer.ProcessingObjectModel.DLL
DEL Microsoft.ReportViewer.WinForms.DLL
DEL Microsoft.SqlServer.Types.dll