```mermaid
classDiagram
class Animal{
+Name string
+Move() void
+Speak() string
}
Animal  <|-- Cat
class Cat{
+Speak() string
}
class Human{
+Name string
+Animals List<Animal>
}
Animal  <|-- Dog
class Dog{
+Speak() string
}
```
