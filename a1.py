import proto_test_pb2  # O nome do arquivo gerado deve corresponder


if __name__ =="__main__":
    import proto_test_pb2  # Adjust based on your generated file name

    # Create an instance of MapComplementaryInformationEvent
    map_event = proto_test_pb2.MapComplementaryInformationEvent(
        subareaId=1,  # Example value for subareaId
        mapId=96338944,  # Example value for mapId
    )

    a = b"\x08\x03\x10\x80\x88\xf8-"
    b = map_event.SerializeToString()

    map_even1111t = proto_test_pb2.MapComplementaryInformationEvent()
    _a = map_even1111t.ParseFromString(a)



    # event_instance = proto_test_pb2.Event(content=map_event)

    # Create an instance of MainMessage and set its content to the Event
    main_message = proto_test_pb2.MainMessage(event=map_event)


    payload = main_message.SerializeToString()
    print(payload)
    # Output the payload
    # print("Serialized Payload:", payload)

    # O payload que você forneceu
    payload = b'\xc1\x02\x1a\xbe\x02\n\xbb\x02\n^type.ankama.com/com.ankama.dofus.server.game.protocol.gamemap.MapComplementaryInformationEvent\x12\xd8\x01\x08\x03\x10\x80\x88\xf8-"n\x08\x87\x87\xf8\x80\xbc\x02\x12\x05\x10\x83\x02\x18\x01\x1a^\n,\x08\x01\x12\nZ\xdc\x10\xff\x04\xf7\x01h\xce\x03\x1a\x18\xc7\xa6\xad\x0b\x80\xc4\xc5\x14\xc2\xd6\xf6\x1e\x80\xfe\xf4"\xb2\x82\x9a-\x8f\xaa\xea7"\x02\xa0\x01\x12.",\n\nChupa-Cano\x12\x1e\n\x01\x0b\x1a\x02X\x01 \xa4\x86\x85N*\x10\x08\x02 \xbe\x87\xf8\x80\xbc\x02(\xbe\x87\xf8\x80\xbc\x02""\x08\xdf\xe3\xfe\xff\xff\xff\xff\xff\xff\x01\x12\x05\x10\xb9\x02\x18\x01\x1a\x0e\n\x03\x08\xb20\x12\x07:\x05\x08\x8a\x06\x10\x01" \x08\xe0\xe3\xfe\xff\xff\xff\xff\xff\xff\x01\x12\x05\x10\xbd\x02\x18\x03\x1a\x0c\n\x03\x08\xb60\x12\x05:\x03\x08\x89\x06*\x19\x08\xde\xf5\x1c\x10\xff\xff\xff\xff\xff\xff\xff\xff\xff\x01\x1a\x06\x08\xb8\x01\x10\xda\x16(\x01'
    print(payload)
    print()


