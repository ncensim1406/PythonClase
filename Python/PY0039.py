import argparse


def comprueba_argumentos():
    parser = argparse.ArgumentParser(
        description="Dibuja una tabla con asteriscos."
    )

    parser.add_argument(
        "filas",
        type=int,
        help="Número de filas (entre 1 y 9)"
    )
    parser.add_argument(
        "columnas",
        type=int,
        help="Número de columnas (entre 1 y 9)"
    )

    args = parser.parse_args()

    if not (1 <= args.filas <= 9 and 1 <= args.columnas <= 9):
        parser.print_help()
        parser.exit(1, "Error: las filas y columnas deben estar entre 1 y 9.\n")

    return args.filas, args.columnas


def dibuja_tabla(filas, columnas):
    for _ in range(filas):
        print("* " * columnas)


dibuja_tabla(6,6)