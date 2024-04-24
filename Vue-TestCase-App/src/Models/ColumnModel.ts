export type Column = {
    Id : number,
    Name : string,
    ColumnType : ColumnType
}
enum ColumnType {
    Number,
    String,
    Text
}