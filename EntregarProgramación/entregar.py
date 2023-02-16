import  sqlite3 as basedatos

conexion = basedatos.connect("examen.db")

cursor = conexion.cursor()



cursor.execute('''
    SELECT *
    FROM apellidos_frecuencia
    LIMIT 100;
    ''')

datos = cursor.fetchall()
for i in datos:
        print(i[1])









