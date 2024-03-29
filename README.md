# OptimMethodKurs
Программный комплекс для решения задачи оптимизации заданного объекта исследования с помощью методов поочередного варьирования и метода Бокса

На разных ветках - разные интерфейсы

Технологии: c#, WPF, Autofac, ReactiveUI, SQLite, EntityFramework 

Объектом оптимизации  является процесс фильтрования с использованием  установки, имеющей две фильтрационные перегородки, на каждой из которых поддерживается свой температурный режим. Известно, что объем фильтрата V(м^3/ч)  связан с температурами T1 и T2 на каждой перегородке следующим образом:
V = α ∙ (T1 - β∙ ∆р1) ∙cos(γ∙∆р2 sqrt(T1^ N + T2^N),
где ∆р1  и  ∆р2 – величина перепада давлений на каждой перегородке (Кпа);       ∆р1 = ∆р2=1;
α, β, γ – нормирующие множители; α= β =1;  γ=3.14;
N – количество перегородок ( 2 шт.).
Для эффективного фильтрования необходимо, чтобы температура на первой перегородке была не ниже -3 °C и не выше 0 °C, а на второй – не выше 3 °C и не ниже -0,5 °C, кроме того, должно выполняться условие:  T2 – T1 ≥ 3°C   .
Необходимо определить  такой температурный режим проведения процесса ( значения Т1 и Т2 ), при котором  обеспечивается максимальный выход фильтрата в м^3  в сутки ( 24 часа).  Точность решения – 0,0 1 °C       


