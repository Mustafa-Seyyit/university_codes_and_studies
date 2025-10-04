public enum HandSign {
    ROCK,
    SCISSOR,
    PAPER;

    // Helper for display
    @Override
    public String toString() {
        return name().charAt(0) + name().substring(1).toLowerCase();
    }
}