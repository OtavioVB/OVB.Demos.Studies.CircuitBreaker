using OVB.Demos.Studies.CircuitBreaker.ENUMs;

namespace OVB.Demos.Studies.CircuitBreaker;

public sealed class CircuitBreaker
{
    public IDictionary<Type, CircuitBreakerState> _dictionaryCircuitBreaker;

    public CircuitBreaker(IDictionary<Type, CircuitBreakerState> dictionaryCircuitBreaker)
    {
        _dictionaryCircuitBreaker = dictionaryCircuitBreaker;
    }
}
