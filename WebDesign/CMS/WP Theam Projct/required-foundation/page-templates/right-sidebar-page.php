<?php
/**
 * Template Name: Right Sidebar Page Template
 * Description: A Page Template with a sidebar on the left side
 *
 * @package required+ Foundation
 * @since required+ Foundation 0.2.0
 */

get_header(); ?>
<?php get_template_part( 'custom-header' ); ?>

<!-- Row for main content area -->
<div id="content" class="row twelve">

  <div id="main" class="nine columns" role="main">
    <div class="post-box">

      <?php while ( have_posts() ) : the_post(); ?>

      <?php get_template_part( 'content', 'page' ); ?>

      <?php
						/**
						 * Seriously I never used comments on a page, what for?
						 */
						//comments_template( '', true );
					?>

      <?php endwhile; // end of the loop. ?>

    </div>
  </div>
  <!-- /#main -->

  <aside id="sidebar" class="three columns" role="complementary">
    <?php get_sidebar('Second-Sidebar'); ?>
  </aside>
  <!-- /#sidebar -->

</div>
<!-- End Content row -->

<?php get_footer(); ?>