types = {
    "root": {},
}


def parse_milliseconds_timestamp(x, type):
    from time import ctime

    return ctime(x / 1000.0)


native_types = {}
