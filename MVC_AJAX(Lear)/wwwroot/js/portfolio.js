// Futuristic Portfolio Animations
document.addEventListener('DOMContentLoaded', function() {
    
    // Create floating particles
    createParticles();
    
    // Smooth scrolling for navigation links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();
            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                target.scrollIntoView({
                    behavior: 'smooth',
                    block: 'start'
                });
            }
        });
    });

    // Enhanced scroll animations
    const observerOptions = {
        threshold: 0.1,
        rootMargin: '0px 0px -50px 0px'
    };

    const observer = new IntersectionObserver(function(entries) {
        entries.forEach((entry, index) => {
            if (entry.isIntersecting) {
                setTimeout(() => {
                    entry.target.classList.add('animate-in');
                }, index * 100);
            }
        });
    }, observerOptions);

    // Observe all cards and sections
    document.querySelectorAll('.card, section').forEach(el => {
        observer.observe(el);
    });

    // Typing animation for hero text
    const heroTitle = document.querySelector('.display-3');
    if (heroTitle) {
        const text = heroTitle.textContent;
        heroTitle.textContent = '';
        heroTitle.classList.add('glitch');
        
        let i = 0;
        const typeWriter = () => {
            if (i < text.length) {
                heroTitle.textContent += text.charAt(i);
                i++;
                setTimeout(typeWriter, 100);
            }
        };
        
        setTimeout(typeWriter, 1000);
    }

    // Mouse trail effect
    let mouseTrail = [];
    document.addEventListener('mousemove', function(e) {
        mouseTrail.push({x: e.clientX, y: e.clientY, time: Date.now()});
        
        if (mouseTrail.length > 10) {
            mouseTrail.shift();
        }
        
        // Remove old trail points
        mouseTrail = mouseTrail.filter(point => Date.now() - point.time < 1000);
    });

    // Add floating animation to skill badges
    document.querySelectorAll('.badge').forEach((badge, index) => {
        badge.style.animationDelay = `${index * 0.1}s`;
        badge.classList.add('floating');
        
        badge.addEventListener('mouseenter', function() {
            this.style.transform = 'scale(1.2) rotate(10deg)';
        });
        
        badge.addEventListener('mouseleave', function() {
            this.style.transform = 'scale(1) rotate(0deg)';
        });
    });

    // Parallax effect for hero section
    window.addEventListener('scroll', function() {
        const scrolled = window.pageYOffset;
        const hero = document.querySelector('.hero');
        if (hero) {
            hero.style.transform = `translateY(${scrolled * 0.5}px)`;
        }
    });

    // Add neon glow effect to headings
    document.querySelectorAll('h2, h4, h5').forEach(heading => {
        heading.classList.add('neon-text');
    });

    // Card tilt effect
    document.querySelectorAll('.card').forEach(card => {
        card.addEventListener('mousemove', function(e) {
            const rect = this.getBoundingClientRect();
            const x = e.clientX - rect.left;
            const y = e.clientY - rect.top;
            
            const centerX = rect.width / 2;
            const centerY = rect.height / 2;
            
            const rotateX = (y - centerY) / 10;
            const rotateY = (centerX - x) / 10;
            
            this.style.transform = `perspective(1000px) rotateX(${rotateX}deg) rotateY(${rotateY}deg) translateZ(10px)`;
        });
        
        card.addEventListener('mouseleave', function() {
            this.style.transform = 'perspective(1000px) rotateX(0) rotateY(0) translateZ(0)';
        });
    });
});

// Create floating particles
function createParticles() {
    const particleContainer = document.createElement('div');
    particleContainer.style.position = 'fixed';
    particleContainer.style.top = '0';
    particleContainer.style.left = '0';
    particleContainer.style.width = '100%';
    particleContainer.style.height = '100%';
    particleContainer.style.pointerEvents = 'none';
    particleContainer.style.zIndex = '1';
    document.body.appendChild(particleContainer);

    for (let i = 0; i < 50; i++) {
        setTimeout(() => {
            createParticle(particleContainer);
        }, i * 200);
    }
}

function createParticle(container) {
    const particle = document.createElement('div');
    particle.classList.add('particle');
    particle.style.left = Math.random() * 100 + '%';
    particle.style.animationDuration = (Math.random() * 3 + 2) + 's';
    particle.style.animationDelay = Math.random() * 2 + 's';
    
    container.appendChild(particle);
    
    setTimeout(() => {
        if (particle.parentNode) {
            particle.parentNode.removeChild(particle);
        }
        createParticle(container);
    }, 5000);
}