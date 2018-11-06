import sqlite3
from connect import db_connect
from sql import *

@db_connect
def query_restaurant(id, connection, cursor):
    if id is not None:
        execute_string = build_select('restaurant', ['id'])
        cursor.execute(execute_string, (id,))
    else:
        execute_string = build_select('restaurant', [])
        cursor.execute(execute_string)
    return create_return_dict(cursor)

@db_connect
def query_restaurant(id, connection, cursor):
    pass

 @db_connect
def query_menu(id, rid, connection, cursor):
    pass

@db_connect
def query_profile(id, connection, cursor):
    pass

@db_connect
def query_order(id, rid, pid, connection, cursor):
    pass

@db_connect
def query_alert(id, rid, status, connection, cursor):
    pass

    

if __name__ == "__main__":
    print(query_restaurant(None))
