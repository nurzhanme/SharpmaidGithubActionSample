```mermaid
classDiagram
Animal  <|-- Cat
class Cat{
+Speak() string
}
class Human{
+Name string
+Animals List<Animal>
}
class Animal{
+Name string
+Move() void
+Speak() string
}
Animal  <|-- Dog
class Dog{
+Speak() string
}
```
