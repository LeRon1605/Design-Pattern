# Singleton Pattern
Singleton là creational design pattern cho phép một class chỉ có một instance và cung cấp khả năng truy cập ở mọi nơi trong chương trình.

## Implementation
![image](https://user-images.githubusercontent.com/78067510/184390896-b498db7a-c794-45f2-abdd-ed13caf8d622.png)

Có rất nhiều cách để implement Singleton Pattern. Nhưng dù cho việc implement bằng cách nào đi nữa cũng dựa vào nguyên tắc dưới đây cơ bản dưới đây:
- Private constructor để hạn chế truy cập từ class bên ngoài.
- Đặt private static variable đảm bảo biến chỉ được khởi tạo trong class.
- Có một method public static để return instance được khởi tạo ở trên.

Dựa trên những nguyên tắc thiết kế Singleton ở trên, chúng ta có các cách implement singleton như sau:
1. Eager initialization
- Singleton Class được khởi tạo ngay khi được gọi đến. Đây là cách dễ nhất nhưng nó có một nhược điểm mặc dù instance đã được khởi tạo mà có thể sẽ không dùng tới.
2. Lazy initialization
- Chỉ khi nào getInstance() được gọi thì instance mới được khởi tạo
3. Thread safe initialization
- Block thread khi truy cập đến getInstance(). Nhược điểm là chạy rất chậm và tốn hiệu năng, bất kỳ Thread nào gọi đến đều phải chờ nếu có một Thread khác đang sử dụng
4. Thread Safe Singleton
- Chỉ block thread khi truy cập đến getInstance() mà instance chưa được khởi tạo

## Applicability
- Dùng khi muốn class chỉ có một instance, quản lí tài nguyên chung
- Việc quản lí truy cập tốt hơn nếu như chỉ có một instance
- Nghiêm ngặt hơn khi truy cập các biến global
