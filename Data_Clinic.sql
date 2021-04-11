USE db_clinic;
select*from tb_receptionist


INSERT INTO tb_turn ( turn )
VALUES 
		( 'Mañana' ), ( 'Tarde' ), ( 'Noche' )
GO
INSERT INTO tb_hour ( entry, departure, id_turn )
VALUES
       ( '08:00:00', '16:00:00', 1 ) ,
       ( '12:00:00', '20:00:00', 2 ) ,
       ( '18:00:00', '00:00:00', 3 ) ;

INSERT INTO tb_speciality ( speciality )
VALUES
       ( 'Dermatología' ), ( 'Ginecología' ) ,
       ( 'Oftalmología' ), ( 'Traumatología' ) ;

INSERT INTO tb_doctor ( name, a_p, a_m, dni, password, id_hour, id_speciality,state )
VALUES
       ( 'William', 'Osler', 'Semmelwei', '78965411', 'password', 2, 1,1 ) ,
       ( 'Ignaz', 'Semmelweis', 'Osle', '78965412', 'password', 1, 3,1 ) ,
       ( 'Sigmund', 'Freud', 'Igna', '78965413', 'password', 1, 2,1 ) ;

INSERT INTO tb_doctor ( name, a_p, a_m, dni, password, id_hour, id_speciality,state )
VALUES
       ( 'Mary', 'A', 'B', '7512565', 'password', 1, 1,1 ) ,
       ( 'Adan', 'C', 'D', '7458645', 'password', 3, 1,1 ) ;
       

INSERT INTO tb_gender ( gender )
VALUES
       ( 'Masculino' ), ( 'Femenino' ) ;

INSERT INTO tb_type_identification ( type )
VALUES
       ( 'DNI' ), ( 'Pasaporte' ), ( 'Carnet de extrangeria' ) ;

INSERT INTO tb_marital_status ( marital_status )
VALUES
       ('Casado' ), ( 'Divorciado' ), ('Viudo'), ('Soltero') ;

INSERT INTO tb_clinic_history ( id )
VALUES
       ( 1 ), ( 2 ), ( 3 );

INSERT INTO tb_health_insurance ( name )
VALUES
       ( 'ESSALUD' ), ( 'SIS' ),('NINGUNO');

INSERT INTO tb_district ( district )
VALUES
       ( 'San Juan de Miraflores' ), ( 'Chorrillos' );

INSERT INTO tb_patient (
                        id, name, a_p, a_m, phone, birthdate,
                        address, hopital_perteneciente, id_type_identification,
                        id_gender, id_marital_status, id_clinic_history,
                        id_health_insurance, id_district )
VALUES
       ( '71062231', 'Alexandra Jaqueline', 'Navarro', 'Navarro', '999999999', '11-11-20' ,
        'Hopital', 'nombre de hostipal' ,
        2, 1, 4, 2 ,
        2, 1 ) ,
       ( '71062232', 'Leonardo Antonio', 'Nolasco', 'Leyva', '996501260', '11-11-20' ,
        'San Genaro', 'San Jose' ,
        1, 1, 4, 1 ,
        1, 2 ) ,
       ( '71062233', 'Chester', 'Mufin', 'Cmcut', '859674123', '11-11-20' ,
        'Pamplona', 'Oyantai' ,
        1, 1, 3, 3 ,
        1, 1 ) ;

INSERT INTO tb_diagnosis (
                          reasons_for_consultation, current_illness,
                          pathological_history, id_clinic_history,
                          id_doctor )
VALUES
       ( 'Malestar general', null, null, 2, 1 ) ,
       ( 'Gripe', null, null, 1, 2 ) ;

INSERT INTO tb_receptionist ( name, a_p, a_m, dni, password,state )
VALUES
       ( 'Wichai', 'Thongthan', 'Vernon', '12345678', '12345678',1 ) ,
       ( 'Vernon', 'Jordan', 'Thongthan', '96587412', '74125896',1 ) ;

INSERT INTO tb_contrareferencia (
                                 est_ref_name, est_ref_dir, est_contref_name,
                                 est_contref_dir, est_contref_diagnosis, treatment,
                                 ind_aps, date_contref,
                                 id_patient,
                                 id_doctor, id_receptionist )
VALUES
       ( 'nombre de posta', 'direccion posta', 'Maria Auxiliadora' ,
        'San Juan de Miraflores', 'diagnostico', 'tratamiento', 'indicaciones de APS', '10-10-20',
        '71062233',
        1, 1) ;

INSERT INTO tb_appointment ( hour, date, id_doctor, id_patient, id_receptionist )
VALUES
        ( '08:30:00', '10-10-20', 1, '71062232', 2 ) ,
        ( '16:30:00', '10-10-20', 2, '71062231', 1 ) ;

INSERT INTO tb_cashier ( name, a_p, a_m, dni, password )
VALUES
        ( 'Almirante Miguel', 'Grau' ,'Seminario', '12344321', 'password') ;

INSERT INTO tb_proof_of_purchase ( id_appointment, id_cashier )
VALUES
        ( 2, 1 ), (1, 1) ;

