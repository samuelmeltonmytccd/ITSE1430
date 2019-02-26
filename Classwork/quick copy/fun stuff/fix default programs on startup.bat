assoc .html=webfile
assoc .htm=1webfile
assoc .http=2webfile
assoc .https=3webfile

ftype webfile=C:\Program Files (x86)\Mozilla Firefox\firefox.exe
ftype 1webfile=C:\Program Files (x86)\Mozilla Firefox\firefox.exe "%1"
ftype 2webfile=C:\Program Files (x86)\Mozilla Firefox\firefox.exe "%1"
ftype 3webfile=C:\Program Files (x86)\Mozilla Firefox\firefox.exe "%1"