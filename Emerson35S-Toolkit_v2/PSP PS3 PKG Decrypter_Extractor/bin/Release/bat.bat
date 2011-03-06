@echo off
cd "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release"
COPY /B "C:\Documents and Settings\Emerson\Desktop\sconsoleDemo.pkg" "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release"
MD "TEST00003"
COPY /B "sconsoleDemo.pkg" "TEST00003"
XCOPY /H "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release\unpkgDebug.exe" "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release\TEST00003"
CD "TEST00003"
unpkgDebug "sconsoleDemo.pkg"
DEL "sconsoleDemo.pkg"
DEL /A:H "unpkgDebug.exe"
cd "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release"
COPY /B "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release\TEST00003\USRDIR\EBOOT.BIN" "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release"
unself EBOOT.BIN EBOOT.ELF
make_self_npdrm "EBOOT.ELF" "EBOOT.BIN" "UP0001-TEST00003_00-0000111122223333
DEL "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release\TEST00003\USRDIR\EBOOT.BIN
COPY /B "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release\EBOOT.BIN" "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release\TEST00003\USRDIR"
cd "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release"
COPY /B "C:\Documents and Settings\Emerson\Desktop\TEST00003.conf" "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release"
psn_package_npdrm "TEST00003.conf" "TEST00003" "UP0001-TEST00003_00-0000111122223333
COPY /B "C:\Documents and Settings\Emerson\Desktop\secret\PSP PS3 PKG Decrypter Extractor v.1.0.0.0\PSP PS3 PKG Decrypter_Extractor\bin\Release\UP0001-TEST00003_00-0000111122223333.pkg" "C:\Documents and Settings\Emerson\Desktop"
DEL test_out
DEL EBOOT.BIN
DEL EBOOT.ELF
DEL "TEST00003.conf"
DEL "sconsoleDemo.pkg"
DEL "UP0001-TEST00003_00-0000111122223333.pkg"
RD /S /Q "TEST00003"