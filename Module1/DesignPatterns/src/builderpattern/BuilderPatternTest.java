package builderpattern;

public class BuilderPatternTest {

    public static void main(String[] args) {
        Computer gamingPC = new Computer.Builder()
                .setCpu("Intel i9")
                .setRam(32)
                .setStorage(1000)
                .setGpu("RTX 4080")
                .setBluetooth(true)
                .build();
        Computer officePC = new Computer.Builder()
                .setCpu("Intel i5")
                .setRam(16)
                .setStorage(512)
                .setGpu("Integrated Graphics")
                .build();
        System.out.println("Gaming PC Configuration:");
        gamingPC.showConfiguration();
        System.out.println("Office PC Configuration:");
        officePC.showConfiguration();
    }
}
