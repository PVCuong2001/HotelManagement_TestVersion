INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 0, '/user-management', 'Manage Users', 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 0, '/room', 'Manage Rooms', 2, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu(  menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES (  1, '/user/list', 'List User', 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES (  1, '/user/add', 'Add User', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 1, '/user/edit', 'Edit User', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu(  menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 1, '/user/delete', 'Delete User', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu(  menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES (  2, '/room-management/roomtype/list', 'List roomtype', 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 2, '/room-management/room/list', 'List rooms', 2, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu(  menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 2, '/room-management/roomtype/add', 'Add Roomtype', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu(  menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 2, '/room-management/roomtype/edit', 'Edit Roomtype', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES (  2, '/room-management/room/add', 'Add Room', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.role( role_name, role_description ) VALUES ( 'Admin', null);
INSERT INTO HotelManagementREAL.dbo.role(  role_name, role_description ) VALUES (  'Clerk', null);
INSERT INTO HotelManagementREAL.dbo.role(  role_name, role_description ) VALUES ( 'Service Staff', null);
INSERT INTO HotelManagementREAL.dbo.role(  role_name, role_description ) VALUES (  'Receptionist', null);
INSERT INTO HotelManagementREAL.dbo.room_type( id_roomtype, roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ( 1, 'single room', null, 1000000, 2);
INSERT INTO HotelManagementREAL.dbo.room_type( id_roomtype, roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ( 2, 'double room', null, 2000000, 4);
INSERT INTO HotelManagementREAL.dbo.room_type( id_roomtype, roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ( 3, 'king room', null, 5000000, 1);
INSERT INTO HotelManagementREAL.dbo.room_type( id_roomtype, roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ( 4, 'queen room', null, 5000000, 1);
INSERT INTO HotelManagementREAL.dbo.room_type( id_roomtype, roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ( 5, 'family room', null, 5000000, 7);
INSERT INTO HotelManagementREAL.dbo.room_type( id_roomtype, roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ( 6, 'president room', null, 1000000, 1);
INSERT INTO HotelManagementREAL.dbo.room_type( id_roomtype, roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ( 7, 'provipRoom', 'qua tot', 100, 2);
INSERT INTO HotelManagementREAL.dbo.[user](user_name, user_photo, user_gmail, user_phone, user_gender, user_activeflag, user_code ) VALUES (  'SuperAdmin', 1, 'cuong@gmail.com', '123456789', 1, 1, 'PVC20011');
INSERT INTO HotelManagementREAL.dbo.[user](user_name, user_photo, user_gmail, user_phone, user_gender, user_activeflag, user_code ) VALUES (  'cuong', 2, 'phanncuongg2001@gmail.com', '987654321', 0, 1, '2001PVC');
INSERT INTO HotelManagementREAL.dbo.user_role(  userol_iduser, userol_idrole, userol_activeflag ) VALUES (  1, 1, 1);
INSERT INTO HotelManagementREAL.dbo.user_role( userol_iduser, userol_idrole, userol_activeflag ) VALUES (  1, 2, 1);
INSERT INTO HotelManagementREAL.dbo.user_role(  userol_iduser, userol_idrole, userol_activeflag ) VALUES ( 2, 2, 1);
INSERT INTO HotelManagementREAL.dbo.user_role( userol_iduser, userol_idrole, userol_activeflag ) VALUES (  2, 3, 1);
INSERT INTO HotelManagementREAL.dbo.ImgStorage( id_imgsto, imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES ( 1, 'hello', 1, null);
INSERT INTO HotelManagementREAL.dbo.ImgStorage( id_imgsto, imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES ( 2, '/home/cuong/Pictures/Images/cheems.jpg', 1, null);
INSERT INTO HotelManagementREAL.dbo.ImgStorage( id_imgsto, imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES ( 3, '/home/cuong/Pictures/cheemscuoi.jpeg', 2, null);
INSERT INTO HotelManagementREAL.dbo.ImgStorage( id_imgsto, imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES ( 4, '/home/cuong/Pictures/cheems_alert.jpg', null, 1);
INSERT INTO HotelManagementREAL.dbo.ImgStorage( id_imgsto, imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES ( 5, '/home/cuong/pro', 7, null);
INSERT INTO HotelManagementREAL.dbo.ImgStorage( id_imgsto, imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES ( 6, '/home/cuong/vip', 7, null);
INSERT INTO HotelManagementREAL.dbo.ImgStorage( id_imgsto, imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES ( 8, 'sasda', 1, null);
INSERT INTO HotelManagementREAL.dbo.auth(  auth_idrole, auth_idmenu, auth_permission, auth_activeflag, auth_createdate, auth_updatedate ) VALUES ( 1, 1, 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.auth(  auth_idrole, auth_idmenu, auth_permission, auth_activeflag, auth_createdate, auth_updatedate ) VALUES (  1, 2, 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.auth( auth_idrole, auth_idmenu, auth_permission, auth_activeflag, auth_createdate, auth_updatedate ) VALUES (  1, 3, 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.auth(  auth_idrole, auth_idmenu, auth_permission, auth_activeflag, auth_createdate, auth_updatedate ) VALUES (  1, 4, 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.auth(  auth_idrole, auth_idmenu, auth_permission, auth_activeflag, auth_createdate, auth_updatedate ) VALUES (  1, 5, 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.room( id_room, room_name, room_description, room_idroomtype ) VALUES ( 2, 'A101', null, 2);
INSERT INTO HotelManagementREAL.dbo.room( id_room, room_name, room_description, room_idroomtype ) VALUES ( 3, 'A102', null, 5);
INSERT INTO HotelManagementREAL.dbo.room( id_room, room_name, room_description, room_idroomtype ) VALUES ( 4, 'A103', null, 4);
INSERT INTO HotelManagementREAL.dbo.room( id_room, room_name, room_description, room_idroomtype ) VALUES ( 5, 'A104', null, 1);
INSERT INTO HotelManagementREAL.dbo.room( id_room, room_name, room_description, room_idroomtype ) VALUES ( 6, 'A105', null, 2);
INSERT INTO HotelManagementREAL.dbo.room( id_room, room_name, room_description, room_idroomtype ) VALUES ( 7, 'A106', null, 1);


insert into HotelManagementREAL.dbo.status(sta_name , sta_description) values ('Maintained','Room is maintained for better service');
insert into HotelManagementREAL.dbo.status(sta_name , sta_description) values ('Bookes','This room is being booked');
insert into HotelManagementREAL.dbo.status(sta_name , sta_description) values ('Occupied','Guests have already taken this room');


insert into HotelManagementREAL.dbo.status_time(statim_fromdate,statim_todate,statim_idroom,statim_idstatus) values ('03/15/2021','03/08/2021',1,1);
insert into HotelManagementREAL.dbo.status_time(statim_fromdate,statim_todate,statim_idroom,statim_idstatus) values ('03/01/2021','02/21/2021',2,2);