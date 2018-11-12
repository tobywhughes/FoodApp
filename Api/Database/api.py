from db_query import *
import json

from flask import Flask, request
app = Flask(__name__)

@app.route('/restaurant', methods=['GET', 'POST', 'PUT', 'DELETE'])
def restaurant():
    if request.method == 'GET':
        id = None
        if 'id' in request.args:
            id = request.args['id']
        return json.dumps(query_restaurant(id))
    return 'not implemented'

@app.route('/menu', methods=['GET', 'POST', 'PUT', 'DELETE'])
def menu():
    if request.method == 'GET':
        id = None
        rid = None

        if 'id' in request.args:
            id = request.args['id']
        if 'rid' in request.args:
            rid = request.args['rid']

        return json.dumps(query_menu(id, rid))
    return 'not implemented'

@app.route('/profile', methods=['GET', 'POST', 'PUT', 'DELETE'])
def profile():
    if request.method == 'GET':
        id = None
        username = None

        if 'id' in request.args:
            id = request.args['id']
        if 'username' in request.args:
            username = request.args['username']

        return json.dumps(query_profile(id, username))
    return 'not implemented'

@app.route('/order', methods=['GET', 'POST', 'PUT', 'DELETE'])
def order():
    if request.method == 'GET':
        id = None
        rid = None
        pid = None

        if 'id' in request.args:
            id = request.args['id']
        if 'rid' in request.args:
            rid = request.args['rid']
        if 'pid' in request.args:
            pid = request.args['pid']

        return json.dumps(query_order(id, rid, pid))
    return 'not implemented'

@app.route('/alert', methods=['GET', 'POST', 'PUT', 'DELETE'])
def alert():
    if request.method == 'GET':
        id = None
        rid = None
        pid = None
        status = None

        if 'id' in request.args:
            id = request.args['id']
        if 'rid' in request.args:
            rid = request.args['rid']
        if 'pid' in request.args:
            pid = request.args['pid']
        if 'status' in request.args:
            status = request.args['status']

        return json.dumps(query_alert(id, rid, pid, status))
    return 'not implemented'

if __name__ == "__main__":
    app.run()