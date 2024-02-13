```mermaid
classDiagram
Animal  <|-- Dog
class Dog{
+Speak() string
}
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
```
